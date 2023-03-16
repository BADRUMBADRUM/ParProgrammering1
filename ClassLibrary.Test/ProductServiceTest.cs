namespace ClassLibrary.Test
{
    [TestClass]
    public class ProductServiceTest
    {
        private readonly ProductService sut;

        public ProductServiceTest()
        {
            sut = new ProductService();
        }
        [TestMethod]
        public void When_fetching_ID_return_product_ID()
        {
            //arrange
            sut.products.Add(new Product { ID = 1, Name = "apelsin", antal = 2, price = 30});
            var prodid = 1;
            //act
            var result = sut.GetProdID(prodid);
            //assert
            Assert.AreEqual(prodid, result.ID);
        }

        [TestMethod]
        public void When_id_is_found_remove_count()
        {
            //arrange
            sut.products.Add(new Product { ID = 1, Name = "apelsin", antal = 3, price = 30 });
            var prodid = 1;
            var removeCount = 1;
            //act
            sut.RemoveProduct(prodid, removeCount);
            //assert
            Assert.AreEqual(2, sut.GetProdID(1).antal);
        }
        [TestMethod]
        public void When_id_is_found_return_count()
        {
            //arrange
            sut.products.Add(new Product { ID = 1, Name = "apelsin", antal = 3, price = 30 });
            var prodid = 1;

            //act
            var result = sut.GetCountForProduct(prodid);
            //assert
            Assert.AreEqual(result, sut.GetProdID(1).antal);
        }

        [TestMethod]
        public void When_adding_product_list_should_result_in_new_list_item()
        {
            //arrange
            sut.products.Add(new Product { ID = 1, Name = "apelsin", antal = 3, price = 30 });
            

            //act
            sut.AddToList(3, "apelsin", 3, 25);
            //assert
            Assert.AreEqual(2, sut.getUniqueProductsCount());
        }
        [TestMethod]
        public void When_adding_but_produkt_already_exist_add_count()
        {
            //arrange
            sut.products.Add(new Product { ID = 1, Name = "apelsin", antal = 3, price = 30 });


            //act
            sut.AddToList(1, "apelsin", 3, 25);
            //assert
            Assert.AreEqual(6, sut.GetProdID(1).antal);
        }
    }
}
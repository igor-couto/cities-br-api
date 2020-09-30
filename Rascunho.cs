Anotation para usar o Object Id: [BsonRepresentation(BsonType.ObjectId)]


busca de cidade:



        // [HttpGet("search")]
        // public IActionResult Get([FromQuery] CityRequest request)
        // {
        //     if (!ModelState.IsValid)
        //         return BadRequest(ModelState);
            
        //     return Json(_cityService.GetCity(request), new JsonSerializerOptions(){IgnoreNullValues = true});
        // }


        // public List<City> GetCity(CityRequest request)
        // {
        //     var builder = Builders<City>.Filter;
        //     var filter = builder.Empty;

            // if(!string.IsNullOrEmpty(request.Name))
            // {
            //     var regex  = new BsonRegularExpression(@"");
            //     filter = builder.And(new [] {filter, builder.Eq("Name", request.Name)}); 
            // }

            // if(!string.IsNullOrEmpty(request.Population))
            // {
            //     if(request.Population[0] == '>')
            //     {
            //         if(request.Population[1] == '=')
            //         {
            //             filter = builder.And(new [] {filter, builder.Gte("Population", Regex.Replace(request.Population, "[^.0-9]", ""))}); 
            //         }
            //         else
            //         {
            //             filter = builder.And(new [] {filter, builder.Gt("Population", Regex.Replace(request.Population, "[^.0-9]", ""))}); 
            //         }
            //     }

            //     if(request.Population[0] == '<')
            //     {
            //         if(request.Population[1] == '=')
            //         {
            //             filter = builder.And(new [] {filter, builder.Lt("Population", Regex.Replace(request.Population, "[^.0-9]", ""))}); 
            //         }
            //         else
            //         {
            //             filter = builder.And(new [] {filter, builder.Lte("Population", Regex.Replace(request.Population, "[^.0-9]", ""))}); 
            //         }
            //     }

            //     if(request.Population.Contains(".."))
            //     {
            //         var numbers = request.Population.Split("..");
            //         filter = builder.And(new [] {filter, builder.Where(x => x.Population >= int.Parse(numbers[0]) && x.Population <= int.Parse(numbers[1]))}); 
            //     }
            // }

            // if(request.IsCapital?? false)
            // {
            //     filter = builder.And(new [] {filter, builder.Eq("IsCapital", true)}); 
            // }

            // if(!string.IsNullOrEmpty(request.State))
            // {
            //     filter = builder.And(new [] {filter, builder.Eq("State", request.State)}); 
            // }

            // IFindFluent<City, City> result;

            // if(request.MaxResultCount != null)
            // {
            //     result = _cityCollection.Find(filter).Limit(request.MaxResultCount.Value);
            // }
            // else
            // {
            //     result = _cityCollection.Find(filter);
            // }

            
            // if(request.Random?? false)
            // {
            //     var random = new Random();  
            //     var documentsCount = (int) _cityCollection.CountDocuments(x => true);
            //     var elementAt = random.Next(0, documentsCount); 

            //     var list = new List<City>(); 
            //     list.Add(result.ToList().ElementAt(elementAt));
            //     return list;
            // }

            // return result.ToList();
        //}
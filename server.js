var express = require('express');
var app = express();
var PORT = 3000;
app.set('view engine', 'ejs');

const movies=[{
    name:"movie1",actors:"act1, act2", director: "dir1"
},
{
    name:"movie2",actors:"act1, act2", director: "dir1"
},
{
    name:"movie3",actors:"act1, act2", director: "dir1"
},
{
    name:"movie4",actors:"act1, act2", director: "dir1"
},{
    name:"movie5",actors:"act1, act2", director: "dir1"
},{
    name:"movie6",actors:"act1, act2", director: "dir1"
},{
    name:"movie7",actors:"act1, act2", director: "dir1"
},{
    name:"movie8",actors:"act1, act2", director: "dir1"
},{
    name:"movie9",actors:"act1, act2", director: "dir1"
},{
    name:"movie10",actors:"act1, act2", director: "dir1"
},
]
app.get("/movie",(req,res)=>{
    res.render("movie",{movies})
})
app.get("/aboutus", (req, res) => {
    res.render("about", { name: "Kanishk" });
  });
  
app.get('/', function(req, res){

	res.render('home',{pawprint:"kp3gm"});
})


app.listen(PORT, function(err){
	if (err) console.log(err);
	console.log("Server listening on PORT", PORT);
});

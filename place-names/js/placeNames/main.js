// Put your code here
let names = [
  "Nashville",
  "Hong Kong",
  "The back yard",
  "Earth",
  "London",
  "The mall",
  "Ryman Auditorium",
  "The Great Wall of China",
];

console.log("All Place Names");
names.forEach((place) => console.log(place));

console.log("");
let theNames = names.filter((place) => {
  if (place.startsWith("The")) {
    return place;
  }
});

console.log("'The' Place Names");
theNames.forEach((place) => console.log(place));

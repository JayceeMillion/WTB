=== function describe_breasts() ===                  
{
    -breast_size <= 10:
        ~ return "flat"
    -breast_size <= 20:
        ~ return "petite"
    -breast_size <= 30:
        ~ return "cute"
    -breast_size <= 40:
        ~ return "perky"
    -breast_size <= 50:
        ~ return "round"
    -breast_size <= 60:
        ~ return "large"
    -breast_size <= 70:
        ~ return "heavy"
    -breast_size <= 80:
        ~ return "massive"
    -breast_size <= 90:
        ~ return "enormous"
    -else: 
        ~ return "gigantic"
}                  
                                
=== function describe_butt() ===                  
{
    -butt_size <= 10:
        ~ return "flat"
    -butt_size <= 20:
        ~ return "small"
    -butt_size <= 30:
        ~ return "average"
    -butt_size <= 40:
        ~ return "shapely"
    -butt_size <= 50:
        ~ return "large"
    -butt_size <= 60:
        ~ return "juicy"
    -butt_size <= 70:
        ~ return "bubbly"
    -butt_size <= 80:
        ~ return "huge"
    -butt_size <= 90:
        ~ return "enormous"
    -else: 
        ~ return "gigantic"
}      

=== function describe_lips() ===                  
{
    -lip_size <= 10:
        ~ return "thin"
    -lip_size <= 20:
        ~ return "kissable"
    -lip_size <= 30:
        ~ return "plump"
    -lip_size <= 40:
        ~ return "juicy"
    -lip_size <= 50:
        ~ return "luscious"
    -lip_size <= 60:
        ~ return "beestung"
    -lip_size <= 70:
        ~ return "swollen"
    -lip_size <= 80:
        ~ return "ballooned"
    -else: 
        ~ return "bloated"
}  

=== function describe_hairlength() ===                  
{
    -hair_length <= 1:
        ~ return "bald"
    -hair_length <= 5:
        ~ return "buzzcut"
    -hair_length <= 10:
        ~ return "pixie cut"
    -hair_length <= 15:
        ~ return "short"
    -hair_length <= 20:
        ~ return "neck-length"
    -hair_length <= 30:
        ~ return "shoulder-length"
    -hair_length <= 40:
        ~ return "collarbone-length"
    -hair_length <= 50:
        ~ return "elbow-length"
    -hair_length <= 60:
        ~ return "cascading"
    -hair_length <= 70:
        ~ return "butt-length"
    -hair_length <= 80:
        ~ return "knee-length"
    -hair_length <= 90:
        ~ return "heel-length"
    -else: 
        ~ return "rapunzel-esque"
}  
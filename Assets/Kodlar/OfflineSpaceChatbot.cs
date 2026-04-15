using UnityEngine;
using TMPro;

public class OfflineSpaceChatbot : MonoBehaviour
{
    public TMP_InputField keyboardInputField;
    public TextMeshProUGUI answerText;

    public RobotTalkController robotTalkController; // «—»ÿ «·—Ê»Ê  Â‰« „‰ «·‹ Inspector

    public void SendMessage()
    {
        string q = keyboardInputField.text.Trim().ToLower();

        if (string.IsNullOrEmpty(q))
        {
            answerText.text = "Please type a question about space.";
            return;
        }

        // ÌŒ·Ì «·—Ê»Ê  Ì»œ√ «·ﬂ·«„ ⁄‰œ ≈—”«· «·”ƒ«·
        if (robotTalkController != null)
        {
            robotTalkController.StartTalking();
        }

        // =========================
        // SOLAR SYSTEM
        // =========================
        if (ContainsAny(q, "solar system", "the solar system"))
        {
            answerText.text =
                "The Solar System is the system of objects that orbit the Sun. It includes the Sun, eight major planets, dwarf planets, moons, asteroids, comets, meteoroids, and vast regions of dust and gas. " +
                "The inner planets are Mercury, Venus, Earth, and Mars. The outer planets are Jupiter, Saturn, Uranus, and Neptune. " +
                "The Solar System formed about 4.6 billion years ago from a giant cloud of gas and dust. Gravity pulled the material together, forming the Sun at the center and the planets around it.";
        }
        else if (ContainsAny(q, "sun", "the sun"))
        {
            answerText.text =
                "The Sun is the star at the center of our Solar System. It is a huge ball of hot glowing gas, mostly hydrogen and helium. " +
                "Energy in the Sun is produced by nuclear fusion, where hydrogen atoms combine to form helium. " +
                "The Sun provides light and heat to Earth and makes life possible. Without the Sun, planets in our Solar System would be cold and dark.";
        }

        // =========================
        // PLANETS
        // =========================
        else if (ContainsAny(q, "mercury"))
        {
            answerText.text =
                "Mercury is the closest planet to the Sun and the smallest major planet in the Solar System. " +
                "It has almost no atmosphere, so temperatures change greatly between day and night. " +
                "During the day Mercury can become extremely hot, while at night it becomes very cold. " +
                "A year on Mercury is very short because it moves quickly around the Sun.";
        }
        else if (ContainsAny(q, "venus"))
        {
            answerText.text =
                "Venus is the second planet from the Sun and is often called Earth's sister planet because of its similar size. " +
                "However, Venus is a very hostile world. Its atmosphere is thick and rich in carbon dioxide, causing an extreme greenhouse effect. " +
                "As a result, Venus is the hottest planet in the Solar System, even hotter than Mercury. " +
                "Its surface pressure is also very high, making it difficult for spacecraft to survive there.";
        }
        else if (ContainsAny(q, "earth"))
        {
            answerText.text =
                "Earth is the third planet from the Sun and the only known planet that supports life. " +
                "It has liquid water on its surface, a protective atmosphere, and suitable temperatures for living organisms. " +
                "Earth's atmosphere contains oxygen and nitrogen, and its magnetic field helps protect it from harmful solar radiation. " +
                "About 71 percent of Earth's surface is covered by water.";
        }
        else if (ContainsAny(q, "mars", "red planet"))
        {
            answerText.text =
                "Mars is the fourth planet from the Sun and is known as the Red Planet because of iron oxide, or rust, on its surface. " +
                "Mars has mountains, valleys, polar ice caps, and signs that liquid water may have existed there long ago. " +
                "Scientists are very interested in Mars because it may have once had conditions suitable for life. " +
                "Mars also has two small moons, Phobos and Deimos.";
        }
        else if (ContainsAny(q, "jupiter"))
        {
            answerText.text =
                "Jupiter is the largest planet in the Solar System. It is a gas giant made mostly of hydrogen and helium. " +
                "Jupiter is famous for the Great Red Spot, which is a giant storm larger than Earth. " +
                "It has many moons, including Ganymede, the largest moon in the Solar System. " +
                "Because of its strong gravity and large size, Jupiter has had a major influence on the structure of the Solar System.";
        }
        else if (ContainsAny(q, "saturn"))
        {
            answerText.text =
                "Saturn is the sixth planet from the Sun and is best known for its beautiful ring system. " +
                "The rings are made mostly of ice and rock particles of many sizes. " +
                "Saturn is a gas giant like Jupiter and has many moons. One of its most famous moons is Titan, which has a thick atmosphere. " +
                "Although Saturn is huge, it is less dense than water.";
        }
        else if (ContainsAny(q, "uranus"))
        {
            answerText.text =
                "Uranus is the seventh planet from the Sun and is classified as an ice giant. " +
                "It is unusual because it rotates on its side, which means its axis is tilted much more than most planets. " +
                "This causes extreme seasons. Uranus appears blue-green because of methane in its atmosphere. " +
                "It is very cold and far from the Sun.";
        }
        else if (ContainsAny(q, "neptune"))
        {
            answerText.text =
                "Neptune is the eighth major planet from the Sun and the farthest one in the Solar System. " +
                "It is an ice giant with a deep blue color caused by methane in its atmosphere. " +
                "Neptune has very strong winds and powerful storms. " +
                "Because it is very far from the Sun, it is a dark and cold world.";
        }
        else if (ContainsAny(q, "pluto"))
        {
            answerText.text =
                "Pluto was once considered the ninth planet, but it is now classified as a dwarf planet. " +
                "It is located in the Kuiper Belt, a region beyond Neptune filled with icy bodies. " +
                "Pluto is small, cold, and distant, and it has several moons, including Charon. " +
                "Its reclassification happened because astronomers found other similar objects in the same region.";
        }
        else if (ContainsAny(q, "planet", "planets"))
        {
            answerText.text =
                "A planet is a large celestial body that orbits a star. In our Solar System, there are eight major planets. " +
                "The inner rocky planets are Mercury, Venus, Earth, and Mars. The outer planets are Jupiter, Saturn, Uranus, and Neptune. " +
                "Some planets are rocky, while others are gas giants or ice giants. " +
                "Planets do not produce their own light; they reflect the light of their star.";
        }

        // =========================
        // MOONS / SMALL BODIES
        // =========================
        else if (ContainsAny(q, "moon", "the moon"))
        {
            answerText.text =
                "The Moon is Earth's natural satellite. It orbits Earth and affects ocean tides because of its gravity. " +
                "The Moon does not produce its own light; it reflects sunlight. " +
                "Humans first landed on the Moon in 1969 during the Apollo 11 mission. " +
                "The Moon has no significant atmosphere, so its surface shows many craters caused by impacts.";
        }
        else if (ContainsAny(q, "asteroid", "asteroids"))
        {
            answerText.text =
                "Asteroids are rocky objects that orbit the Sun. Many of them are found in the asteroid belt between Mars and Jupiter. " +
                "They are smaller than planets and come in many shapes and sizes. " +
                "Some asteroids are leftovers from the early Solar System, so studying them helps scientists understand how planets formed.";
        }
        else if (ContainsAny(q, "comet", "comets"))
        {
            answerText.text =
                "Comets are icy bodies that orbit the Sun. When a comet gets close to the Sun, heat causes its ice to vaporize and form a glowing coma and sometimes a long tail. " +
                "The tail points away from the Sun because of solar wind and radiation pressure. " +
                "Comets are often described as dirty snowballs because they contain ice, dust, and rocky material.";
        }
        else if (ContainsAny(q, "meteor", "meteoroid", "meteorite"))
        {
            answerText.text =
                "A meteoroid is a small piece of rock or metal traveling through space. " +
                "When it enters Earth's atmosphere and burns because of friction, it is called a meteor. " +
                "If part of it survives and reaches the ground, it is called a meteorite. " +
                "Meteors are often called shooting stars, even though they are not actually stars.";
        }
        else if (ContainsAny(q, "kuiper belt"))
        {
            answerText.text =
                "The Kuiper Belt is a region beyond Neptune filled with icy objects and dwarf planets, including Pluto. " +
                "It is similar in some ways to the asteroid belt, but it is much larger and contains more icy material. " +
                "The Kuiper Belt helps scientists study the outer Solar System and its early history.";
        }

        // =========================
        // STARS / GALAXIES / UNIVERSE
        // =========================
        else if (ContainsAny(q, "star", "stars"))
        {
            answerText.text =
                "A star is a massive ball of hot gas, mainly hydrogen and helium, that produces energy through nuclear fusion. " +
                "Stars come in different sizes, colors, temperatures, and lifetimes. " +
                "Some stars are much larger and hotter than the Sun, while others are smaller and cooler. " +
                "Stars are born in giant clouds of gas and dust called nebulae.";
        }
        else if (ContainsAny(q, "galaxy", "galaxies"))
        {
            answerText.text =
                "A galaxy is a huge collection of stars, gas, dust, planets, and dark matter held together by gravity. " +
                "Galaxies can be spiral, elliptical, or irregular in shape. " +
                "Our galaxy is called the Milky Way. " +
                "There are billions of galaxies in the observable universe, and each galaxy may contain billions of stars.";
        }
        else if (ContainsAny(q, "milky way"))
        {
            answerText.text =
                "The Milky Way is the galaxy that contains our Solar System. It is a spiral galaxy with billions of stars. " +
                "Our Sun is located in one of its spiral arms, not at the center. " +
                "At the center of the Milky Way, astronomers believe there is a supermassive black hole. " +
                "When we look at the night sky from dark places, we can sometimes see part of the Milky Way as a bright band.";
        }
        else if (ContainsAny(q, "universe"))
        {
            answerText.text =
                "The universe includes all of space, time, matter, energy, galaxies, stars, planets, and everything that exists. " +
                "Scientists believe the universe began about 13.8 billion years ago in an event called the Big Bang. " +
                "Since then, the universe has been expanding. " +
                "The universe is incredibly large, and much of it is still not fully understood.";
        }
        else if (ContainsAny(q, "big bang"))
        {
            answerText.text =
                "The Big Bang is the scientific theory that explains how the universe began. " +
                "It suggests that the universe started from a very hot and dense state and has been expanding ever since. " +
                "The Big Bang was not an explosion in space, but the rapid expansion of space itself. " +
                "Evidence for the theory includes the expansion of galaxies and the cosmic microwave background radiation.";
        }
        else if (ContainsAny(q, "nebula", "nebulae"))
        {
            answerText.text =
                "A nebula is a giant cloud of gas and dust in space. Some nebulae are regions where new stars are born, while others are the remains of dead stars. " +
                "Nebulae can be very colorful and beautiful. " +
                "They are important because they are part of the life cycle of stars.";
        }
        else if (ContainsAny(q, "supernova"))
        {
            answerText.text =
                "A supernova is a powerful explosion that happens at the end of the life of some stars. " +
                "It can briefly outshine an entire galaxy. " +
                "Supernovae spread heavy elements into space, and these elements later help form new stars, planets, and even living things. " +
                "Some black holes and neutron stars form after supernova explosions.";
        }
        else if (ContainsAny(q, "black hole", "black holes"))
        {
            answerText.text =
                "A black hole is a region in space where gravity is so strong that nothing, not even light, can escape. " +
                "Black holes can form when very massive stars collapse at the end of their lives. " +
                "There are also supermassive black holes at the centers of many galaxies. " +
                "Although black holes cannot be seen directly, scientists can detect them by observing how they affect nearby stars and gas.";
        }
        else if (ContainsAny(q, "neutron star"))
        {
            answerText.text =
                "A neutron star is the incredibly dense remnant left behind after a massive star explodes as a supernova. " +
                "It is very small compared with a normal star, but its mass can be greater than the mass of the Sun. " +
                "Neutron stars have extremely strong gravity and magnetic fields.";
        }

        // =========================
        // SPACE EXPLORATION
        // =========================
        else if (ContainsAny(q, "astronaut", "astronauts"))
        {
            answerText.text =
                "Astronauts are people trained to travel and work in space. " +
                "They perform scientific experiments, repair equipment, operate spacecraft, and live in challenging conditions. " +
                "Astronauts must train physically and mentally because space missions require teamwork, discipline, and problem solving.";
        }
        else if (ContainsAny(q, "rocket", "rockets"))
        {
            answerText.text =
                "A rocket is a vehicle that moves by expelling gas at high speed in the opposite direction. " +
                "Rockets are used to launch satellites, probes, and astronauts into space. " +
                "They must overcome Earth's gravity, which requires a lot of energy and fuel. " +
                "Modern rockets can have multiple stages to improve efficiency.";
        }
        else if (ContainsAny(q, "satellite", "satellites"))
        {
            answerText.text =
                "A satellite is an object that orbits a planet or another larger body. " +
                "Natural satellites include moons, while artificial satellites are built by humans. " +
                "Artificial satellites are used for communication, weather forecasting, navigation, and scientific observation.";
        }
        else if (ContainsAny(q, "iss", "international space station", "space station"))
        {
            answerText.text =
                "The International Space Station, or ISS, is a large space laboratory that orbits Earth. " +
                "Astronauts from different countries live and work there, performing scientific experiments in microgravity. " +
                "The ISS is an example of international cooperation in space exploration.";
        }
        else if (ContainsAny(q, "nasa"))
        {
            answerText.text =
                "NASA stands for the National Aeronautics and Space Administration. It is the United States space agency. " +
                "NASA is responsible for many major missions in space exploration, Earth observation, and scientific research. " +
                "Its programs include human spaceflight, Mars exploration, telescopes, and planetary missions.";
        }
        else if (ContainsAny(q, "spacex"))
        {
            answerText.text =
                "SpaceX is a private aerospace company known for developing reusable rockets and spacecraft. " +
                "It has launched satellites, cargo, and astronauts into space. " +
                "Reusable rocket technology helps reduce the cost of space travel.";
        }
        else if (ContainsAny(q, "apollo 11", "apollo"))
        {
            answerText.text =
                "Apollo 11 was the mission that first landed humans on the Moon in 1969. " +
                "Neil Armstrong and Buzz Aldrin walked on the lunar surface, while Michael Collins remained in orbit. " +
                "This mission was a major achievement in human history and space exploration.";
        }
        else if (ContainsAny(q, "telescope", "telescopes"))
        {
            answerText.text =
                "A telescope is an instrument used to observe distant objects in space. " +
                "Some telescopes observe visible light, while others detect radio waves, infrared, ultraviolet, or X-rays. " +
                "Space telescopes are especially useful because they do not have to look through Earth's atmosphere.";
        }
        else if (ContainsAny(q, "hubble"))
        {
            answerText.text =
                "The Hubble Space Telescope is one of the most famous telescopes ever launched into space. " +
                "It has captured detailed images of planets, nebulae, galaxies, and distant stars. " +
                "Hubble has helped scientists learn more about the age and expansion of the universe.";
        }
        else if (ContainsAny(q, "james webb", "jwst", "webb telescope"))
        {
            answerText.text =
                "The James Webb Space Telescope is a powerful space telescope designed to observe the universe in infrared light. " +
                "It helps scientists study the earliest galaxies, star formation, exoplanets, and the atmospheres of distant worlds. " +
                "It can look farther into space and further back in time than many previous telescopes.";
        }
        else if (ContainsAny(q, "exoplanet", "exoplanets"))
        {
            answerText.text =
                "An exoplanet is a planet that orbits a star outside our Solar System. " +
                "Scientists have discovered thousands of exoplanets using telescopes and space missions. " +
                "Some are gas giants, while others are rocky worlds. " +
                "A major goal of exoplanet research is to find planets that may have conditions suitable for life.";
        }
        else if (ContainsAny(q, "alien", "life on other planets", "extraterrestrial"))
        {
            answerText.text =
                "Scientists have not yet confirmed the existence of alien life, but many researchers think it is possible that life may exist elsewhere in the universe. " +
                "They study Mars, icy moons, and exoplanets to search for environments that could support life. " +
                "The search for extraterrestrial life is one of the most exciting topics in space science.";
        }

        // =========================
        // DEFAULT
        // =========================
        else
        {
            answerText.text =
                "I can answer many questions about space. Try asking about the Sun, planets, the Moon, asteroids, comets, black holes, galaxies, the Milky Way, the universe, astronauts, rockets, satellites, NASA, the ISS, Hubble, James Webb, exoplanets, and more.";
        }

        keyboardInputField.text = "";
    }

    private bool ContainsAny(string text, params string[] keywords)
    {
        foreach (string keyword in keywords)
        {
            if (text.Contains(keyword))
                return true;
        }
        return false;
    }
}

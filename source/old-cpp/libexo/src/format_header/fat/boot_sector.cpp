#include <exo/format_header/fat/boot_sector.hpp>

namespace exo {
namespace format_header {
namespace fat {


const u16 permissible_bpb_bytes_per_sec[4] = {512, 1024, 2048, 4096};
const u8 permissible_bpb_sec_per_clus[8] = {1, 2, 4, 8, 16, 32, 64, 128};


} /* namespace fat */
} /* namespace format_header */
} /* namespace exo */

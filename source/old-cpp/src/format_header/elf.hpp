#ifndef EXO_FORMAT_HEADER_ELF_HPP_INCLUDED
#define EXO_FORMAT_HEADER_ELF_HPP_INCLUDED

#include <exo/attributes.hpp>
#include <exo/math/std_types.hpp>


namespace exo {
namespace format_header {


namespace detail {


template<int bits>
struct types
{
    /** Type for a 16-bit quantity. */
    typedef typename math::uint_<16>::type half_type;

    /* Types for signed and unsigned 32-bit quantities. */
    typedef typename math::uint_<32>::type  word_type;
    typedef    typename math::sint_<32>::type sword_type;

    /* Types for signed and unsigned 64-bit quantities. */
    typedef typename math::uint_<64>::type  xword_type;
    typedef    typename math::sint_<64>::type sxword_type;

    /** Type of addresses. */
    typedef typename math::uint_<bits>::type addr_type;

    /** Type of file offsets. */
    typedef typename math::uint_<bits>::type off_type;

    /** Type for section indices, which are 16-bit quantities. */
    typedef typename math::uint_<16>::type section_type;

    /** Type for version symbol information. */
    typedef half_type versym_type;


    typedef typename math::uint_<bits>::type __u_type;
    typedef typename math::sint_<bits>::type __s_type;
};


/** Symbol table entry. */
template<int bits>
struct sym
{};

template<>
struct sym<32>
{
    types<32>::word_type    st_name;    /* Symbol name (string tbl index) */
    types<32>::addr_type    st_value;    /* Symbol value */
    types<32>::word_type    st_size;    /* Symbol size */
    unsigned char            st_info;    /* Symbol type and binding */
    unsigned char            st_other;    /* Symbol visibility */
    types<32>::section_type    st_shndx;    /* Section index */
} __attribute_packed__;

template<>
struct sym<64>
{
    types<64>::word_type    st_name;    /* Symbol name (string tbl index) */
    unsigned char            st_info;    /* Symbol type and binding */
    unsigned char            st_other;    /* Symbol visibility */
    types<64>::section_type    st_shndx;    /* Section index */
    types<64>::addr_type    st_value;    /* Symbol value */
    types<64>::xword_type    st_size;    /* Symbol size */
} __attribute_packed__;


/** Program segment header. */
template<int bits>
struct phdr
{};

template<>
struct phdr<32>
{
    types<32>::word_type    p_type;        /* Segment type */
    types<32>::off_type     p_offset;    /* Segment file offset */
    types<32>::addr_type    p_vaddr;    /* Segment virtual address */
    types<32>::addr_type    p_paddr;    /* Segment physical address */
    types<32>::word_type    p_filesz;    /* Segment size in file */
    types<32>::word_type    p_memsz;    /* Segment size in memory */
    types<32>::word_type    p_flags;    /* Segment flags */
    types<32>::word_type    p_align;    /* Segment alignment */
} __attribute_packed__;

template<>
struct phdr<64>
{
    types<64>::word_type    p_type;        /* Segment type */
    types<64>::word_type    p_flags;    /* Segment flags */
    types<64>::off_type     p_offset;    /* Segment file offset */
    types<64>::addr_type    p_vaddr;    /* Segment virtual address */
    types<64>::addr_type    p_paddr;    /* Segment physical address */
    types<64>::xword_type    p_filesz;    /* Segment size in file */
    types<64>::xword_type    p_memsz;    /* Segment size in memory */
    types<64>::xword_type    p_align;    /* Segment alignment */
} __attribute_packed__;


} /* namespace detail */


template<int bits>
struct elf
{
    /** Type for a 16-bit quantity. */
    typedef typename detail::types<bits>::half_type half_type;

    /* Types for signed and unsigned 32-bit quantities. */
    typedef typename detail::types<bits>::word_type   word_type;
    typedef    typename detail::types<bits>::sword_type sword_type;

    /* Types for signed and unsigned 64-bit quantities. */
    typedef typename detail::types<bits>::xword_type   xword_type;
    typedef    typename detail::types<bits>::sxword_type sxword_type;

    /** Type of addresses. */
    typedef typename detail::types<bits>::addr_type addr_type;

    /** Type of file offsets. */
    typedef typename detail::types<bits>::off_type off_type;

    /** Type for section indices, which are 16-bit quantities. */
    typedef typename detail::types<bits>::section_type section_type;

    /** Type for version symbol information. */
    typedef typename detail::types<bits>::versym_type versym_type;


    typedef typename detail::types<bits>::__u_type __u_type;
    typedef typename detail::types<bits>::__s_type __s_type;


    /** The ELF file header.  This appears at the start of every ELF file. */
    struct ehdr
    {
        unsigned char    e_ident[16];    /* Magic number and other info */
        half_type    e_type;            /* Object file type */
        half_type    e_machine;        /* Architecture */
        word_type    e_version;        /* Object file version */
        addr_type    e_entry;        /* Entry point virtual address */
        off_type    e_phoff;        /* Program header table file offset */
        off_type    e_shoff;        /* Section header table file offset */
        word_type    e_flags;        /* Processor-specific flags */
        half_type    e_ehsize;        /* ELF header size in bytes */
        half_type    e_phentsize;    /* Program header table entry size */
        half_type    e_phnum;        /* Program header table entry count */
        half_type    e_shentsize;    /* Section header table entry size */
        half_type    e_shnum;        /* Section header table entry count */
        half_type    e_shstrndx;        /* Section header string table index */

        bool is_correct()
        {
            // + check 'bits' with ehdr.e_ident[class].
            throw exo::exception::not_implemented();
        }
    } __attribute_packed__;

    /** Section header. */
    struct shdr
    {
        word_type    sh_name;        /* Section name (string tbl index) */
        word_type    sh_type;        /* Section type */
        __u_type    sh_flags;        /* Section flags */
        addr_type    sh_addr;        /* Section virtual addr at execution */
        off_type    sh_offset;        /* Section file offset */
        __u_type    sh_size;        /* Section size in bytes */
        word_type    sh_link;        /* Link to another section */
        word_type    sh_info;        /* Additional section information */
        __u_type    sh_addralign;    /* Section alignment */
        __u_type    sh_entsize;        /* Entry size if section holds table */
    } __attribute_packed__;

    /** Symbol table entry. */
    typedef detail::sym<bits> sym;

    /** The syminfo section if available contains additional information about
       every dynamic symbol. */
    struct syminfo
    {
        half_type    si_boundto;        /* Direct bindings, symbol bound to */
        half_type    si_flags;        /* Per symbol flags */
    } __attribute_packed__;

    /** Relocation table entry without addend (in section of type SHT_REL). */
    struct rel
    {
        addr_type    r_offset;    /* Address */
        __u_type    r_info;        /* Relocation type and symbol index */
    } __attribute_packed__;

    /** Relocation table entry with addend (in section of type SHT_RELA). */
    struct rela
    {
        addr_type    r_offset;    /* Address */
        __u_type    r_info;        /* Relocation type and symbol index */
        __s_type    r_addend;    /* Addend */
    } __attribute_packed__;

    /** Program segment header. */
    typedef detail::phdr<bits> phdr;

    /** Dynamic section entry. */
    struct dyn
    {
        __s_type    d_tag;        /* Dynamic entry type */
        union
        {
            __u_type    d_val;    /* Integer value */
            addr_type    d_ptr;    /* Address value */
        } d_un;
    } __attribute_packed__;

    /** Version definition sections. */
    struct verdef
    {
        half_type    vd_version;    /* Version revision */
        half_type    vd_flags;    /* Version information */
        half_type    vd_ndx;        /* Version Index */
        half_type    vd_cnt;        /* Number of associated aux entries */
        word_type    vd_hash;    /* Version name hash value */
        word_type    vd_aux;        /* Offset in bytes to verdaux array */
        word_type    vd_next;    /* Offset in bytes to next verdef entry */
    } __attribute_packed__;

    /** Auxialiary version information. */
    struct verdaux
    {
        word_type    vda_name;    /* Version or dependency names */
        word_type    vda_next;    /* Offset in bytes to next verdaux entry */
    } __attribute_packed__;

    /** Version dependency section. */
    struct verneed
    {
        half_type    vn_version;    /* Version of structure */
        half_type    vn_cnt;        /* Number of associated aux entries */
        word_type    vn_file;    /* Offset of filename for this dependency */
        word_type    vn_aux;        /* Offset in bytes to vernaux array */
        word_type    vn_next;    /* Offset in bytes to next verneed entry */
    } __attribute_packed__;

    /** Auxiliary needed version information. */
    struct vernaux
    {
        word_type    vna_hash;    /* Hash value of dependency name */
        half_type    vna_flags;    /* Dependency specific information */
        half_type    vna_other;    /* Unused */
        word_type    vna_name;    /* Dependency name string offset */
        word_type    vna_next;    /* Offset in bytes to next vernaux entry */
    } __attribute_packed__;

    /** Note section contents.  Each entry in the note section begins with
       a header of a fixed form. */
    struct nhdr
    {
      word_type    n_namesz;    /* Length of the note's name. */
      word_type    n_descsz;    /* Length of the note's descriptor. */
      word_type    n_type;        /* Type of the note. */
    } __attribute_packed__;

    /** Move records. */
    struct move
    {
      xword_type    m_value;    /* Symbol value. */
      __u_type        m_info;        /* Size and index. */
      __u_type        m_poffset;    /* Symbol offset. */
      half_type        m_repeat;    /* Repeat count. */
      half_type        m_stride;    /* Stride info. */
    } __attribute_packed__;
};


} /* namespace format_header */
} /* namespace exo */

#endif /* EXO_FORMAT_HEADER_ELF_HPP_INCLUDED */

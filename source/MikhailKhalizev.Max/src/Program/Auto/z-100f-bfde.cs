using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("25bb2be3-63b2-468e-a718-03c0a0f88891")]
        public void Method_100f_bfde()
        {
            ii(0x100f_bfde, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100f_bfe3, 5); calld(Definitions.sys_check_available_stack_size, 0x69d6a); /* call 0x10165d52 */
            ii(0x100f_bfe8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_bfe9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_bfea, 1); pushd(edx);                             /* push edx */
            ii(0x100f_bfeb, 1); pushd(esi);                             /* push esi */
            ii(0x100f_bfec, 1); pushd(edi);                             /* push edi */
            ii(0x100f_bfed, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_bfee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_bff0, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_bff6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_bff9, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100f_bffd, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_c000, 5); calld(Definitions.my_string_ctor, 0x45ae3); /* call 0x10141ae8 */
            ii(0x100f_c005, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_c008, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100f_c00c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c010, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_c013, 6); mov(edx, memd_a32[ds, eax + 0x101b_b444]); /* mov edx, [eax+0x101bb444] */
            ii(0x100f_c019, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_c01c, 5); calld(0x1014_21cb, 0x461aa);            /* call 0x101421cb */
            ii(0x100f_c021, 5); mov(edx, 0x101a_2965);                  /* mov edx, 0x101a2965 */ /* ":\n" */
            ii(0x100f_c026, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_c029, 5); calld(Definitions.my_string_append_char_ptr, 0x45d11); /* call 0x10141d3f */
            ii(0x100f_c02e, 5); mov(edx, 0x101a_2968);                  /* mov edx, 0x101a2968 */ /* "Select starting location." */
            ii(0x100f_c033, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_c036, 5); calld(Definitions.my_string_append_char_ptr, 0x45d04); /* call 0x10141d3f */
            ii(0x100f_c03b, 5); calld(0x100c_aa00, -0x31640);           /* call 0x100caa00 */
            ii(0x100f_c040, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_c045, 1); pushd(eax);                             /* push eax */
            ii(0x100f_c046, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100f_c04b, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_c050, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_c052, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_c055, 5); calld(Definitions.my_strobj_c_str_v2, -0x72892); /* call 0x100897c8 */
            ii(0x100f_c05a, 5); calld(0x1011_5d23, 0x19cc4);            /* call 0x10115d23 */
            ii(0x100f_c05f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_c061, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_c064, 5); calld(Definitions.my_string_dtor, 0x45ac1); /* call 0x10141b2a */
            ii(0x100f_c069, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_c06b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_c06c, 1); popd(edi);                              /* pop edi */
            ii(0x100f_c06d, 1); popd(esi);                              /* pop esi */
            ii(0x100f_c06e, 1); popd(edx);                              /* pop edx */
            ii(0x100f_c06f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_c070, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_c071, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("14d3665a-9ca0-424f-b7d5-b1d75273fa11")]
        public void Method_1015_a6aa()
        {
            ii(0x1015_a6aa, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1015_a6af, 5); calld(Definitions.sys_check_available_stack_size, 0xb69e); /* call 0x10165d52 */
            ii(0x1015_a6b4, 1); pushd(esi);                             /* push esi */
            ii(0x1015_a6b5, 1); pushd(edi);                             /* push edi */
            ii(0x1015_a6b6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_a6b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_a6b9, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_a6bf, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_a6c2, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1015_a6c5, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1015_a6c8, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1015_a6cb, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1015_a6cf, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_a6d2, 5); calld(Definitions.my_ctor_0x101b38f8, -0xe3fe7); /* call 0x100766f0 */
            ii(0x1015_a6d7, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_a6da, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1015_a6de, 5); calld(0x1010_2b84, -0x57b5f);           /* call 0x10102b84 */
            ii(0x1015_a6e3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_a6e8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a6e9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_a6ee, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a6ef, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_a6f1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a6f2, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1015_a6f6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a6f7, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1015_a6fb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a6fc, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_a6fe, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1015_a702, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1015_a706, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_a709, 5); calld(0x1015_a2da, -0x434);             /* call 0x1015a2da */
            ii(0x1015_a70e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_a710, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_a713, 5); calld(0x1008_ac18, -0xcfb00);           /* call 0x1008ac18 */
            ii(0x1015_a718, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_a71a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_a71d, 5); calld(0x1007_5f2c, -0xe47f6);           /* call 0x10075f2c */
            ii(0x1015_a722, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1015_a725, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_a728, 5); calld(0x1007_6574, -0xe41b9);           /* call 0x10076574 */
            ii(0x1015_a72d, 5); calld(0x1008_a998, -0xcfd9a);           /* call 0x1008a998 */
            ii(0x1015_a732, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1015_a736, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_a739, 5); calld(0x1007_6574, -0xe41ca);           /* call 0x10076574 */
            ii(0x1015_a73e, 5); calld(0x1014_f634, -0xb10f);            /* call 0x1014f634 */
            ii(0x1015_a743, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1015_a746, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_a749, 5); calld(0x1007_6668, -0xe40e6);           /* call 0x10076668 */
            ii(0x1015_a74e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_a750, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_a753, 5); calld(0x1007_5f2c, -0xe482c);           /* call 0x10075f2c */
            ii(0x1015_a758, 2); jmpd(0x1015_a764, 0xa); goto l_0x1015_a764; /* jmp 0x1015a764 */
        //  ii(0x1015_a75a, 10); Недостижимый код.
l_0x1015_a764:
            ii(0x1015_a764, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_a767, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_a769, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_a76a, 1); popd(edi);                              /* pop edi */
            ii(0x1015_a76b, 1); popd(esi);                              /* pop esi */
            ii(0x1015_a76c, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}

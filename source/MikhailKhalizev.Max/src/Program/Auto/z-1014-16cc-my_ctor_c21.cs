using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_16cc-96d39938")]
        public void my_ctor_c21()
        {
            ii(0x1014_16cc, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_16d1, 5); calld(Definitions.sys_check_available_stack_size, 0x2_467c); /* call 0x10165d52 */
            ii(0x1014_16d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_16d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_16d8, 1); pushd(edx);                             /* push edx */
            ii(0x1014_16d9, 1); pushd(esi);                             /* push esi */
            ii(0x1014_16da, 1); pushd(edi);                             /* push edi */
            ii(0x1014_16db, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_16dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_16de, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_16e4, 5); mov(eax, 0x101b_d700);                  /* mov eax, 0x101bd700 */
            ii(0x1014_16e9, 5); calld(/* sys */ 0x1016_611f, 0x2_4a31); /* call 0x1016611f */
            ii(0x1014_16ee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_16f0, 5); mov(eax, 0x101c_8114);                  /* mov eax, 0x101c8114 */
            ii(0x1014_16f5, 5); calld(Definitions.my_string_ctor_capaticy, 0x2d6); /* call 0x101419d0 */
            ii(0x1014_16fa, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_16fd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_1700, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_1703, 10); mov(memd_a32[ds, 0x101b_d708], 0x1);   /* mov dword [0x101bd708], 0x1 */
            ii(0x1014_170d, 5); mov(eax, 0x101c_8118);                  /* mov eax, 0x101c8118 */
            ii(0x1014_1712, 5); calld(Definitions.my_string_ctor, 0x3d1); /* call 0x10141ae8 */
            ii(0x1014_1717, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_171a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_171d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_1720, 10); mov(memd_a32[ds, 0x101b_d708], 0x2);   /* mov dword [0x101bd708], 0x2 */
            ii(0x1014_172a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_172c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_172d, 1); popd(edi);                              /* pop edi */
            ii(0x1014_172e, 1); popd(esi);                              /* pop esi */
            ii(0x1014_172f, 1); popd(edx);                              /* pop edx */
            ii(0x1014_1730, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1731, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1732, 1); retd();                                 /* ret */
        }
    }
}

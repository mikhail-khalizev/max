using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_16cc-96d39938")]
        public void my_ctor_c21()
        {
            ii(0x1014_16cc, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1014_16d1, 5); call(Definitions.sys_check_available_stack_size, 0x2_467c); /* call 0x10165d52 */
            ii(0x1014_16d6, 1); push(ebx);                              /* push ebx */
            ii(0x1014_16d7, 1); push(ecx);                              /* push ecx */
            ii(0x1014_16d8, 1); push(edx);                              /* push edx */
            ii(0x1014_16d9, 1); push(esi);                              /* push esi */
            ii(0x1014_16da, 1); push(edi);                              /* push edi */
            ii(0x1014_16db, 1); push(ebp);                              /* push ebp */
            ii(0x1014_16dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_16de, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_16e4, 5); mov(eax, 0x101b_d700);                  /* mov eax, 0x101bd700 */
            ii(0x1014_16e9, 5); call(/* sys */ 0x1016_611f, 0x2_4a31);  /* call 0x1016611f */
            ii(0x1014_16ee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_16f0, 5); mov(eax, 0x101c_8114);                  /* mov eax, 0x101c8114 */
            ii(0x1014_16f5, 5); call(Definitions.my_string_ctor_capaticy, 0x2d6); /* call 0x101419d0 */
            ii(0x1014_16fa, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_16fd, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_1700, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_1703, 10); mov(memd[ds, 0x101b_d708], 1);         /* mov dword [0x101bd708], 0x1 */
            ii(0x1014_170d, 5); mov(eax, 0x101c_8118);                  /* mov eax, 0x101c8118 */
            ii(0x1014_1712, 5); call(Definitions.my_string_ctor, 0x3d1); /* call 0x10141ae8 */
            ii(0x1014_1717, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_171a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_171d, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_1720, 10); mov(memd[ds, 0x101b_d708], 2);         /* mov dword [0x101bd708], 0x2 */
            ii(0x1014_172a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_172c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_172d, 1); pop(edi);                               /* pop edi */
            ii(0x1014_172e, 1); pop(esi);                               /* pop esi */
            ii(0x1014_172f, 1); pop(edx);                               /* pop edx */
            ii(0x1014_1730, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_1731, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_1732, 1); ret();                                  /* ret */
        }
    }
}

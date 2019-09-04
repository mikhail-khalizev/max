using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_8600-4dc32cc1")]
        public void Method_1014_8600()
        {
            ii(0x1014_8600, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_8605, 5);  call(Definitions.sys_check_available_stack_size, 0x1_d748);/* call 0x10165d52 */
            ii(0x1014_860a, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_860b, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_860c, 1);  push(edx);                            /* push edx */
            ii(0x1014_860d, 1);  push(esi);                            /* push esi */
            ii(0x1014_860e, 1);  push(edi);                            /* push edi */
            ii(0x1014_860f, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_8610, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_8612, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_8618, 5);  mov(eax, 0x101b_d8dc);                /* mov eax, 0x101bd8dc */
            ii(0x1014_861d, 5);  call(/* sys */ 0x1016_611f, 0x1_dafd);/* call 0x1016611f */
            ii(0x1014_8622, 5);  mov(eax, 0x101c_813c);                /* mov eax, 0x101c813c */
            ii(0x1014_8627, 5);  call(0x1014_8894, 0x268);             /* call 0x10148894 */
            ii(0x1014_862c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_862f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_8632, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_8635, 10);  mov(memd[ds, 0x101b_d8e4], 1);       /* mov dword [0x101bd8e4], 0x1 */
            ii(0x1014_863f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_8641, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_8642, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_8643, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_8644, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_8645, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_8646, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_8647, 1);  ret();                                /* ret */
        }
    }
}

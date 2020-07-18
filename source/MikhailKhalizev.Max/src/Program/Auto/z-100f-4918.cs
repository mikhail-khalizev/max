using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4918-835fec96")]
        public void Method_100f_4918()
        {
            ii(0x100f_4918, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100f_491d, 5);  call(Definitions.sys_check_available_stack_size, 0x7_1430);/* call 0x10165d52 */
            ii(0x100f_4922, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_4923, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_4924, 1);  push(edx);                            /* push edx */
            ii(0x100f_4925, 1);  push(esi);                            /* push esi */
            ii(0x100f_4926, 1);  push(edi);                            /* push edi */
            ii(0x100f_4927, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_4928, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_492a, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100f_4930, 3);  mov(memb[ss, ebp - 4], al);           /* mov [ebp-0x4], al */
            ii(0x100f_4933, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100f_4936, 5);  mov(memb[ds, 0x101c_37cb], al);       /* mov [0x101c37cb], al */
            ii(0x100f_493b, 5);  mov(al, memb[ds, 0x101c_37cb]);       /* mov al, [0x101c37cb] */
            ii(0x100f_4940, 5);  mov(memb[ds, 0x101b_8861], al);       /* mov [0x101b8861], al */
            ii(0x100f_4945, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_4947, 6);  mov(dl, memb[ds, 0x101c_37cb]);       /* mov dl, [0x101c37cb] */
            ii(0x100f_494d, 5);  mov(eax, memd[ds, 0x101b_885d]);      /* mov eax, [0x101b885d] */
            ii(0x100f_4952, 5);  call(0x100c_fb73, -0x2_4de4);         /* call 0x100cfb73 */
            ii(0x100f_4957, 5);  call(0x100f_f5c1, 0xac65);            /* call 0x100ff5c1 */
            ii(0x100f_495c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_495e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_495f, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_4960, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_4961, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_4962, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_4963, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_4964, 1);  ret();                                /* ret */
        }
    }
}

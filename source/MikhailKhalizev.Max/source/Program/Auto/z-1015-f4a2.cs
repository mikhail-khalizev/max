using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_f4a2-998981a7")]
        public void Method_1015_f4a2()
        {
            ii(0x1015_f4a2, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1015_f4a7, 5);  call(Definitions.sys_check_available_stack_size, 0x68a6);/* call 0x10165d52 */
            ii(0x1015_f4ac, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_f4ad, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_f4ae, 1);  push(edx);                            /* push edx */
            ii(0x1015_f4af, 1);  push(esi);                            /* push esi */
            ii(0x1015_f4b0, 1);  push(edi);                            /* push edi */
            ii(0x1015_f4b1, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_f4b2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_f4b4, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1015_f4ba, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_f4bd, 5);  mov(edx, 0x101c_37bc);                /* mov edx, 0x101c37bc */
            ii(0x1015_f4c2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_f4c5, 5);  call(0x1007_6d98, -0xe_8732);         /* call 0x10076d98 */
            ii(0x1015_f4ca, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_f4cc, 2);  if(jz(0x1015_f4d3, 5)) goto l_0x1015_f4d3;/* jz 0x1015f4d3 */
            ii(0x1015_f4ce, 5);  call(0x100f_fc13, -0x5_f8c0);         /* call 0x100ffc13 */
        l_0x1015_f4d3:
            ii(0x1015_f4d3, 5);  mov(edx, 0x28);                       /* mov edx, 0x28 */
            ii(0x1015_f4d8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_f4db, 5);  call(0x1015_1399, -0xe147);           /* call 0x10151399 */
            ii(0x1015_f4e0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_f4e3, 4);  mov(memb[ds, eax + 62], 0x16);        /* mov byte [eax+0x3e], 0x16 */
            ii(0x1015_f4e7, 5);  mov(ebx, 0x22);                       /* mov ebx, 0x22 */
            ii(0x1015_f4ec, 5);  mov(edx, 0x17);                       /* mov edx, 0x17 */
            ii(0x1015_f4f1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_f4f4, 5);  call(0x1016_2f96, 0x3a9d);            /* call 0x10162f96 */
            ii(0x1015_f4f9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_f4fb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_f4fc, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_f4fd, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_f4fe, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_f4ff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_f500, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_f501, 1);  ret();                                /* ret */
        }
    }
}

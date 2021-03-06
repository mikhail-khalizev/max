using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ab57-30585094")]
        public void Method_1009_ab57()
        {
            ii(0x1009_ab57, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_ab5c, 5);  call(Definitions.sys_check_available_stack_size, 0xc_b1f1);/* call 0x10165d52 */
            ii(0x1009_ab61, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_ab62, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_ab63, 1);  push(esi);                            /* push esi */
            ii(0x1009_ab64, 1);  push(edi);                            /* push edi */
            ii(0x1009_ab65, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_ab66, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_ab68, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_ab6e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_ab71, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_ab74, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_ab77, 3);  add(edx, 0x13);                       /* add edx, 0x13 */
            ii(0x1009_ab7a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ab7d, 5);  call(0x1007_6d98, -0x2_3dea);         /* call 0x10076d98 */
            ii(0x1009_ab82, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_ab84, 2);  if(jz(0x1009_abb6, 0x30)) goto l_0x1009_abb6;/* jz 0x1009abb6 */
            ii(0x1009_ab86, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_ab88, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ab8b, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_ab8e, 5);  call(0x1007_6630, -0x2_4563);         /* call 0x10076630 */
            ii(0x1009_ab93, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_ab95, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ab98, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_ab9b, 5);  call(0x1013_ad71, 0xa_01d1);          /* call 0x1013ad71 */
            ii(0x1009_aba0, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_aba2, 2);  if(jz(0x1009_abb6, 0x12)) goto l_0x1009_abb6;/* jz 0x1009abb6 */
            ii(0x1009_aba4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_aba7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_abaa, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_abad, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_abb0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_abb3, 3);  call_abs(memd[ds, edx + 112]);        /* call dword [edx+0x70] */
        l_0x1009_abb6:
            ii(0x1009_abb6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_abb8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_abb9, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_abba, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_abbb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_abbc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_abbd, 1);  ret();                                /* ret */
        }
    }
}

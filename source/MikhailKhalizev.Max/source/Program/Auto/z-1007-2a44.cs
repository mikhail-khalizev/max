using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_2a44-6e7e8bec")]
        public void Method_1007_2a44()
        {
            ii(0x1007_2a44, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1007_2a49, 5);  call(Definitions.sys_check_available_stack_size, 0xf_3304);/* call 0x10165d52 */
            ii(0x1007_2a4e, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_2a4f, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_2a50, 1);  push(edx);                            /* push edx */
            ii(0x1007_2a51, 1);  push(esi);                            /* push esi */
            ii(0x1007_2a52, 1);  push(edi);                            /* push edi */
            ii(0x1007_2a53, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_2a54, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_2a56, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_2a5c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_2a5f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2a62, 4);  cmp(memb[ds, eax + 78], 0);           /* cmp byte [eax+0x4e], 0x0 */
            ii(0x1007_2a66, 2);  if(jnz(0x1007_2a6e, 6)) goto l_0x1007_2a6e;/* jnz 0x10072a6e */
            ii(0x1007_2a68, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_2a6c, 2);  jmp(0x1007_2ad6, 0x68); goto l_0x1007_2ad6;/* jmp 0x10072ad6 */
        l_0x1007_2a6e:
            ii(0x1007_2a6e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2a70, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2a73, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x1007_2a76, 5);  call(0x1013_ad11, 0xc_8296);          /* call 0x1013ad11 */
            ii(0x1007_2a7b, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_2a7d, 2);  if(jz(0x1007_2a85, 6)) goto l_0x1007_2a85;/* jz 0x10072a85 */
            ii(0x1007_2a7f, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1007_2a83, 2);  jmp(0x1007_2ad6, 0x51); goto l_0x1007_2ad6;/* jmp 0x10072ad6 */
        l_0x1007_2a85:
            ii(0x1007_2a85, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2a88, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x1007_2a8b, 5);  call(0x1007_69d8, 0x3f48);            /* call 0x100769d8 */
            ii(0x1007_2a90, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_2a93, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_2a96, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1007_2a99, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_2a9c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_2a9f, 3);  call_abs(memd[ds, ebx + 36]);         /* call dword [ebx+0x24] */
            ii(0x1007_2aa2, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1007_2aa5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2aa8, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1007_2aab, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_2ab0, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_2ab3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_2ab5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2ab8, 3);  mov(al, memb[ds, eax + 100]);         /* mov al, [eax+0x64] */
            ii(0x1007_2abb, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_2ac0, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_2ac2, 2);  cmp(ebx, eax);                        /* cmp ebx, eax */
            ii(0x1007_2ac4, 2);  if(jge(0x1007_2acc, 6)) goto l_0x1007_2acc;/* jge 0x10072acc */
            ii(0x1007_2ac6, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_2aca, 2);  jmp(0x1007_2ad0, 4); goto l_0x1007_2ad0;/* jmp 0x10072ad0 */
        l_0x1007_2acc:
            ii(0x1007_2acc, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1007_2ad0:
            ii(0x1007_2ad0, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1007_2ad3, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
        l_0x1007_2ad6:
            ii(0x1007_2ad6, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1007_2ad9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_2adb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_2adc, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_2add, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_2ade, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_2adf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_2ae0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_2ae1, 1);  ret();                                /* ret */
        }
    }
}

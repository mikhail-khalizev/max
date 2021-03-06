using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8a87-b6dfa126")]
        public void Method_100c_8a87()
        {
            ii(0x100c_8a87, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_8a8c, 5);  call(Definitions.sys_check_available_stack_size, 0x9_d2c1);/* call 0x10165d52 */
            ii(0x100c_8a91, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_8a92, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_8a93, 1);  push(edx);                            /* push edx */
            ii(0x100c_8a94, 1);  push(esi);                            /* push esi */
            ii(0x100c_8a95, 1);  push(edi);                            /* push edi */
            ii(0x100c_8a96, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_8a97, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_8a99, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_8a9f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_8aa2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8aa5, 4);  cmp(memd[ds, eax + 6], 0);            /* cmp dword [eax+0x6], 0x0 */
            ii(0x100c_8aa9, 6);  if(jz(0x100c_8b23, 0x74)) goto l_0x100c_8b23;/* jz 0x100c8b23 */
            ii(0x100c_8aaf, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100c_8ab6, 2);  jmp(0x100c_8abe, 6); goto l_0x100c_8abe;/* jmp 0x100c8abe */
        l_0x100c_8ab8:
            ii(0x100c_8ab8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8abb, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x100c_8abe:
            ii(0x100c_8abe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8ac1, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_8ac4, 3);  cmp(ax, memw[ds, edx]);               /* cmp ax, [edx] */
            ii(0x100c_8ac7, 2);  if(jge(0x100c_8af9, 0x30)) goto l_0x100c_8af9;/* jge 0x100c8af9 */
            ii(0x100c_8ac9, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100c_8acd, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_8ad0, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_8ad2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8ad5, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_8ad8, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8ada, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_8adc, 5);  call(Definitions.sys_delete, 0x9_d483);/* call 0x10165f64 */
            ii(0x100c_8ae1, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_8ae5, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100c_8ae8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8aeb, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x100c_8aee, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8af0, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_8af2, 5);  call(Definitions.sys_delete, 0x9_d46d);/* call 0x10165f64 */
            ii(0x100c_8af7, 2);  jmp(0x100c_8ab8, -0x41); goto l_0x100c_8ab8;/* jmp 0x100c8ab8 */
        l_0x100c_8af9:
            ii(0x100c_8af9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8afc, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_8aff, 5);  call(Definitions.sys_delete, 0x9_d460);/* call 0x10165f64 */
            ii(0x100c_8b04, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8b07, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x100c_8b0a, 5);  call(Definitions.sys_delete, 0x9_d455);/* call 0x10165f64 */
            ii(0x100c_8b0f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8b12, 7);  mov(memd[ds, eax + 6], 0);            /* mov dword [eax+0x6], 0x0 */
            ii(0x100c_8b19, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8b1c, 7);  mov(memd[ds, eax + 2], 0);            /* mov dword [eax+0x2], 0x0 */
        l_0x100c_8b23:
            ii(0x100c_8b23, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_8b25, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_8b26, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_8b27, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_8b28, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_8b29, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_8b2a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_8b2b, 1);  ret();                                /* ret */
        }
    }
}

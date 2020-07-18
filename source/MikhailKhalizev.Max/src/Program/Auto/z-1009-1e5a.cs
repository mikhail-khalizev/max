using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_1e5a-8af47d8a")]
        public void Method_1009_1e5a()
        {
            ii(0x1009_1e5a, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1009_1e5f, 5);  call(Definitions.sys_check_available_stack_size, 0xd_3eee);/* call 0x10165d52 */
            ii(0x1009_1e64, 1);  push(esi);                            /* push esi */
            ii(0x1009_1e65, 1);  push(edi);                            /* push edi */
            ii(0x1009_1e66, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_1e67, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_1e69, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1009_1e6f, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_1e72, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1009_1e75, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_1e78, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1009_1e7b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_1e7e, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1009_1e82, 2);  if(jle(0x1009_1ea7, 0x23)) goto l_0x1009_1ea7;/* jle 0x10091ea7 */
            ii(0x1009_1e84, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_1e87, 3);  sub(eax, memd[ss, ebp - 8]);          /* sub eax, [ebp-0x8] */
            ii(0x1009_1e8a, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_1e8d, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1009_1e90, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1009_1e92, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_1e97, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1009_1e9b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_1e9d, 2);  if(jle(0x1009_1ea7, 8)) goto l_0x1009_1ea7;/* jle 0x10091ea7 */
            ii(0x1009_1e9f, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1009_1ea2, 3);  mov(edx, memd[ss, ebp + 16]);         /* mov edx, [ebp+0x10] */
            ii(0x1009_1ea5, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
        l_0x1009_1ea7:
            ii(0x1009_1ea7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_1eaa, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1009_1eae, 2);  if(jge(0x1009_1ed4, 0x24)) goto l_0x1009_1ed4;/* jge 0x10091ed4 */
            ii(0x1009_1eb0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_1eb3, 3);  sub(eax, memd[ss, ebp - 12]);         /* sub eax, [ebp-0xc] */
            ii(0x1009_1eb6, 4);  mov(memw[ss, ebp - 24], ax);          /* mov [ebp-0x18], ax */
            ii(0x1009_1eba, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1009_1ebd, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1009_1ebf, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_1ec4, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1009_1ec8, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_1eca, 2);  if(jle(0x1009_1ed4, 8)) goto l_0x1009_1ed4;/* jle 0x10091ed4 */
            ii(0x1009_1ecc, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1009_1ecf, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1009_1ed2, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
        l_0x1009_1ed4:
            ii(0x1009_1ed4, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1009_1ed7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_1ed9, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1009_1edb, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1009_1ede, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1009_1ee0, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_1ee5, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_1ee7, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1009_1eeb, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_1eed, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_1ef1, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1009_1ef3, 3);  cmp(edx, 6);                          /* cmp edx, 0x6 */
            ii(0x1009_1ef6, 2);  if(jg(0x1009_1efe, 6)) goto l_0x1009_1efe;/* jg 0x10091efe */
            ii(0x1009_1ef8, 4);  mov(memb[ss, ebp - 28], 1);           /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1009_1efc, 2);  jmp(0x1009_1f02, 4); goto l_0x1009_1f02;/* jmp 0x10091f02 */
        l_0x1009_1efe:
            ii(0x1009_1efe, 4);  mov(memb[ss, ebp - 28], 0);           /* mov byte [ebp-0x1c], 0x0 */
        l_0x1009_1f02:
            ii(0x1009_1f02, 3);  mov(al, memb[ss, ebp - 28]);          /* mov al, [ebp-0x1c] */
            ii(0x1009_1f05, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x1009_1f08, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x1009_1f0b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_1f0d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_1f0e, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_1f0f, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_1f10, 3);  ret(8);                               /* ret 0x8 */
        }
    }
}

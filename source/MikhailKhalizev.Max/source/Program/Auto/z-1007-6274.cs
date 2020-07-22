using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6274-3cb8ea18")]
        public void Method_1007_6274()
        {
            ii(0x1007_6274, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_6279, 5);  call(Definitions.sys_check_available_stack_size, 0xe_fad4);/* call 0x10165d52 */
            ii(0x1007_627e, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_627f, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6280, 1);  push(esi);                            /* push esi */
            ii(0x1007_6281, 1);  push(edi);                            /* push edi */
            ii(0x1007_6282, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6283, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6285, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_628b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_628e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_6291, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_6295, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1007_6298, 7);  cmp(memb[ds, eax + 176], 0);          /* cmp byte [eax+0xb0], 0x0 */
            ii(0x1007_629f, 2);  if(jnz(0x1007_62b1, 0x10)) goto l_0x1007_62b1;/* jnz 0x100762b1 */
            ii(0x1007_62a1, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_62a5, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1007_62a8, 7);  cmp(memb[ds, eax + 171], 0);          /* cmp byte [eax+0xab], 0x0 */
            ii(0x1007_62af, 2);  if(jz(0x1007_62b7, 6)) goto l_0x1007_62b7;/* jz 0x100762b7 */
        l_0x1007_62b1:
            ii(0x1007_62b1, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_62b5, 2);  jmp(0x1007_62bb, 4); goto l_0x1007_62bb;/* jmp 0x100762bb */
        l_0x1007_62b7:
            ii(0x1007_62b7, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1007_62bb:
            ii(0x1007_62bb, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_62be, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1007_62c1, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1007_62c4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_62c6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_62c7, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_62c8, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_62c9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_62ca, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_62cb, 1);  ret();                                /* ret */
        }
    }
}

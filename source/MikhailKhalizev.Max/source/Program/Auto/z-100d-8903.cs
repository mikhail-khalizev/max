using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_8903-ef893f6a")]
        public void Method_100d_8903()
        {
            ii(0x100d_8903, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100d_8908, 5);  call(Definitions.sys_check_available_stack_size, 0x8_d445);/* call 0x10165d52 */
            ii(0x100d_890d, 1);  push(esi);                            /* push esi */
            ii(0x100d_890e, 1);  push(edi);                            /* push edi */
            ii(0x100d_890f, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_8910, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_8912, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100d_8918, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_891b, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100d_891e, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x100d_8921, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x100d_8924, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_8927, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_892a, 3);  mov(memb[ds, edx + 14], al);          /* mov [edx+0xe], al */
            ii(0x100d_892d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_8930, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_8933, 4);  mov(memw[ds, edx + 15], ax);          /* mov [edx+0xf], ax */
            ii(0x100d_8937, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_893a, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_893d, 4);  mov(memw[ds, edx + 17], ax);          /* mov [edx+0x11], ax */
            ii(0x100d_8941, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_8944, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_8947, 3);  mov(memd[ds, edx + 21], eax);         /* mov [edx+0x15], eax */
            ii(0x100d_894a, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100d_894d, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_8950, 4);  mov(memw[ds, edx + 31], ax);          /* mov [edx+0x1f], ax */
            ii(0x100d_8954, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_8957, 4);  cmp(memb[ds, eax + 14], 9);           /* cmp byte [eax+0xe], 0x9 */
            ii(0x100d_895b, 2);  if(jnz(0x100d_8968, 0xb)) goto l_0x100d_8968;/* jnz 0x100d8968 */
            ii(0x100d_895d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_8960, 6);  mov(memw[ds, eax + 19], 1);           /* mov word [eax+0x13], 0x1 */
            ii(0x100d_8966, 2);  jmp(0x100d_89bc, 0x54); goto l_0x100d_89bc;/* jmp 0x100d89bc */
        l_0x100d_8968:
            ii(0x100d_8968, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_896b, 3);  mov(eax, memd[ds, eax + 13]);         /* mov eax, [eax+0xd] */
            ii(0x100d_896e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_8971, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
            ii(0x100d_8974, 2);  if(jge(0x100d_8981, 0xb)) goto l_0x100d_8981;/* jge 0x100d8981 */
            ii(0x100d_8976, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_8979, 6);  mov(memw[ds, eax + 19], 1);           /* mov word [eax+0x13], 0x1 */
            ii(0x100d_897f, 2);  jmp(0x100d_89bc, 0x3b); goto l_0x100d_89bc;/* jmp 0x100d89bc */
        l_0x100d_8981:
            ii(0x100d_8981, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_8984, 3);  mov(eax, memd[ds, eax + 13]);         /* mov eax, [eax+0xd] */
            ii(0x100d_8987, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_898a, 3);  cmp(eax, 0x19);                       /* cmp eax, 0x19 */
            ii(0x100d_898d, 2);  if(jge(0x100d_899a, 0xb)) goto l_0x100d_899a;/* jge 0x100d899a */
            ii(0x100d_898f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_8992, 6);  mov(memw[ds, eax + 19], 2);           /* mov word [eax+0x13], 0x2 */
            ii(0x100d_8998, 2);  jmp(0x100d_89bc, 0x22); goto l_0x100d_89bc;/* jmp 0x100d89bc */
        l_0x100d_899a:
            ii(0x100d_899a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_899d, 3);  mov(eax, memd[ds, eax + 13]);         /* mov eax, [eax+0xd] */
            ii(0x100d_89a0, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_89a3, 3);  cmp(eax, 0x32);                       /* cmp eax, 0x32 */
            ii(0x100d_89a6, 2);  if(jge(0x100d_89b3, 0xb)) goto l_0x100d_89b3;/* jge 0x100d89b3 */
            ii(0x100d_89a8, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_89ab, 6);  mov(memw[ds, eax + 19], 5);           /* mov word [eax+0x13], 0x5 */
            ii(0x100d_89b1, 2);  jmp(0x100d_89bc, 9); goto l_0x100d_89bc;/* jmp 0x100d89bc */
        l_0x100d_89b3:
            ii(0x100d_89b3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_89b6, 6);  mov(memw[ds, eax + 19], 0xa);         /* mov word [eax+0x13], 0xa */
        l_0x100d_89bc:
            ii(0x100d_89bc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_89be, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_89bf, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_89c0, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_89c1, 3);  ret(8);                               /* ret 0x8 */
        }
    }
}

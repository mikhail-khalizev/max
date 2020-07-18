using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9928-fa193d29")]
        public void Method_1008_9928()
        {
            ii(0x1008_9928, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_992d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c420);/* call 0x10165d52 */
            ii(0x1008_9932, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_9933, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_9934, 1);  push(edx);                            /* push edx */
            ii(0x1008_9935, 1);  push(esi);                            /* push esi */
            ii(0x1008_9936, 1);  push(edi);                            /* push edi */
            ii(0x1008_9937, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_9938, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_993a, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_9940, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_9943, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9946, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1008_9949, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1008_994c, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1008_994f, 2);  if(jl(0x1008_9957, 6)) goto l_0x1008_9957;/* jl 0x10089957 */
            ii(0x1008_9951, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_9955, 2);  jmp(0x1008_995b, 4); goto l_0x1008_995b;/* jmp 0x1008995b */
        l_0x1008_9957:
            ii(0x1008_9957, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1008_995b:
            ii(0x1008_995b, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_995e, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1008_9961, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_9964, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_9966, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_9967, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_9968, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_9969, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_996a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_996b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_996c, 1);  ret();                                /* ret */
        }
    }
}

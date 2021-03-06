using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_c32c-789f0d0f")]
        public void Method_100f_c32c()
        {
            ii(0x100f_c32c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100f_c331, 5);  call(Definitions.sys_check_available_stack_size, 0x6_9a1c);/* call 0x10165d52 */
            ii(0x100f_c336, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_c337, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_c338, 1);  push(edx);                            /* push edx */
            ii(0x100f_c339, 1);  push(esi);                            /* push esi */
            ii(0x100f_c33a, 1);  push(edi);                            /* push edi */
            ii(0x100f_c33b, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_c33c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_c33e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100f_c344, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_c347, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_c34a, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100f_c34c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_c34f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_c352, 3);  movsx(edx, memw[ds, edx]);            /* movsx edx, word [edx] */
            ii(0x100f_c355, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100f_c357, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_c359, 5);  call(/* sys */ 0x1016_5e9b, 0x6_9b3d);/* call 0x10165e9b */
            ii(0x100f_c35e, 1);  inc(edx);                             /* inc edx */
            ii(0x100f_c35f, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x100f_c362, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100f_c365, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_c368, 3);  movsx(ecx, memw[ds, edx]);            /* movsx ecx, word [edx] */
            ii(0x100f_c36b, 2);  add(ecx, eax);                        /* add ecx, eax */
            ii(0x100f_c36d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_c370, 2);  mov(ebx, memd[ds, edx]);              /* mov ebx, [edx] */
            ii(0x100f_c372, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100f_c375, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_c378, 3);  movsx(eax, memw[ds, edx]);            /* movsx eax, word [edx] */
            ii(0x100f_c37b, 2);  sub(ebx, eax);                        /* sub ebx, eax */
            ii(0x100f_c37d, 5);  call(/* sys */ 0x1016_5e9b, 0x6_9b19);/* call 0x10165e9b */
            ii(0x100f_c382, 1);  inc(ebx);                             /* inc ebx */
            ii(0x100f_c383, 3);  imul(eax, ebx);                       /* imul eax, ebx */
            ii(0x100f_c386, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100f_c389, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100f_c38b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_c38e, 3);  movsx(eax, memw[ds, edx]);            /* movsx eax, word [edx] */
            ii(0x100f_c391, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100f_c393, 2);  add(eax, ecx);                        /* add eax, ecx */
            ii(0x100f_c395, 3);  lea(edx, memd[ds, eax + 1]);          /* lea edx, [eax+0x1] */
            ii(0x100f_c398, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100f_c39a, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100f_c39d, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100f_c39f, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100f_c3a1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_c3a4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_c3a7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_c3a9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_c3aa, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_c3ab, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_c3ac, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_c3ad, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_c3ae, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_c3af, 1);  ret();                                /* ret */
        }
    }
}

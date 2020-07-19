using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b325-6efbfd05")]
        public void Method_1013_b325()
        {
            ii(0x1013_b325, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1013_b32a, 5);  call(Definitions.sys_check_available_stack_size, 0x2_aa23);/* call 0x10165d52 */
            ii(0x1013_b32f, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_b330, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_b331, 1);  push(edx);                            /* push edx */
            ii(0x1013_b332, 1);  push(esi);                            /* push esi */
            ii(0x1013_b333, 1);  push(edi);                            /* push edi */
            ii(0x1013_b334, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_b335, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_b337, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_b33d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_b340, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1013_b347, 2);  jmp(0x1013_b34f, 6); goto l_0x1013_b34f;/* jmp 0x1013b34f */
        l_0x1013_b349:
            ii(0x1013_b349, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b34c, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x1013_b34f:
            ii(0x1013_b34f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b352, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_b355, 4);  cmp(ax, memw[ds, edx + 4]);           /* cmp ax, [edx+0x4] */
            ii(0x1013_b359, 2);  if(jge(0x1013_b387, 0x2c)) goto l_0x1013_b387;/* jge 0x1013b387 */
            ii(0x1013_b35b, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_b35e, 5);  call(Definitions.my_ctor_0x101b_6edc, -0xc_451f);/* call 0x10076e44 */
            ii(0x1013_b363, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1013_b365, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_b369, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1013_b36c, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1013_b36e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_b371, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1013_b374, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1013_b376, 5);  call(0x1013_acc5, -0x6b6);            /* call 0x1013acc5 */
            ii(0x1013_b37b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_b37d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_b380, 5);  call(Definitions.my_dtor_0x101b_6edc, -0x740);/* call 0x1013ac45 */
            ii(0x1013_b385, 2);  jmp(0x1013_b349, -0x3e); goto l_0x1013_b349;/* jmp 0x1013b349 */
        l_0x1013_b387:
            ii(0x1013_b387, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_b38a, 6);  mov(memw[ds, eax + 4], 0);            /* mov word [eax+0x4], 0x0 */
            ii(0x1013_b390, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_b392, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_b393, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_b394, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_b395, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_b396, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_b397, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_b398, 1);  ret();                                /* ret */
        }
    }
}

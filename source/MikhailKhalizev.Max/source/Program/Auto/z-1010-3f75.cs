using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_3f75-d88bf2f7")]
        public void Method_1010_3f75()
        {
            ii(0x1010_3f75, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1010_3f7a, 5);  call(Definitions.sys_check_available_stack_size, 0x6_1dd3);/* call 0x10165d52 */
            ii(0x1010_3f7f, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_3f80, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_3f81, 1);  push(esi);                            /* push esi */
            ii(0x1010_3f82, 1);  push(edi);                            /* push edi */
            ii(0x1010_3f83, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_3f84, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_3f86, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1010_3f8c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_3f8f, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_3f92, 4);  cmp(memd[ss, ebp - 4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1010_3f96, 2);  if(jnz(0x1010_3fb1, 0x19)) goto l_0x1010_3fb1;/* jnz 0x10103fb1 */
            ii(0x1010_3f98, 5);  mov(ecx, 0x1a9);                      /* mov ecx, 0x1a9 */
            ii(0x1010_3f9d, 5);  mov(ebx, StringDefinitions.HashCpp);  /* mov ebx, 0x101a326f */
            ii(0x1010_3fa2, 5);  mov(edx, StringDefinitions.AttemptedToRemoveNullUnitFromUnitHashTable);/* mov edx, 0x101a3278 */
            ii(0x1010_3fa7, 5);  mov(eax, StringDefinitions.UnitNotEqual0);/* mov eax, 0x101a32ac */
            ii(0x1010_3fac, 5);  call(0x100f_07d4, -0x1_37dd);         /* call 0x100f07d4 */
        l_0x1010_3fb1:
            ii(0x1010_3fb1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3fb4, 5);  call(0x1007_6154, -0x8_de65);         /* call 0x10076154 */
            ii(0x1010_3fb9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_3fbb, 3);  mov(dx, ax);                          /* mov dx, ax */
            ii(0x1010_3fbe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3fc1, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x1010_3fc4, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1010_3fc6, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1010_3fc9, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1010_3fcb, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1010_3fce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3fd1, 4);  movsx(ebx, memw[ss, ebp - 12]);       /* movsx ebx, word [ebp-0xc] */
            ii(0x1010_3fd5, 3);  imul(ebx, ebx, 0xa);                  /* imul ebx, ebx, 0xa */
            ii(0x1010_3fd8, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_3fdb, 3);  mov(edx, memd[ds, edx + 2]);          /* mov edx, [edx+0x2] */
            ii(0x1010_3fde, 2);  add(ebx, edx);                        /* add ebx, edx */
            ii(0x1010_3fe0, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_3fe2, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1010_3fe4, 5);  call(0x1008_aab4, -0x7_9535);         /* call 0x1008aab4 */
            ii(0x1010_3fe9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_3feb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_3fec, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_3fed, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_3fee, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_3fef, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_3ff0, 1);  ret();                                /* ret */
        }
    }
}

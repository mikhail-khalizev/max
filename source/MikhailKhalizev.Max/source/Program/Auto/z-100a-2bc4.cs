using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2bc4-c60e6b25")]
        public void Method_100a_2bc4()
        {
            ii(0x100a_2bc4, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_2bc9, 5);  call(Definitions.sys_check_available_stack_size, 0xc_3184);/* call 0x10165d52 */
            ii(0x100a_2bce, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_2bcf, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_2bd0, 1);  push(esi);                            /* push esi */
            ii(0x100a_2bd1, 1);  push(edi);                            /* push edi */
            ii(0x100a_2bd2, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_2bd3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_2bd5, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100a_2bdb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_2bde, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_2be1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_2be4, 3);  mov(eax, memd[ds, eax + 11]);         /* mov eax, [eax+0xb] */
            ii(0x100a_2be7, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_2bea, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100a_2bee, 5);  add(eax, 0xff);                       /* add eax, 0xff */
            ii(0x100a_2bf3, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100a_2bf5, 2);  if(jge(0x100a_2c00, 9)) goto l_0x100a_2c00;/* jge 0x100a2c00 */
            ii(0x100a_2bf7, 7);  mov(memd[ss, ebp - 12], 0xffff_ffff); /* mov dword [ebp-0xc], 0xffffffff */
            ii(0x100a_2bfe, 2);  jmp(0x100a_2c37, 0x37); goto l_0x100a_2c37;/* jmp 0x100a2c37 */
        l_0x100a_2c00:
            ii(0x100a_2c00, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_2c03, 3);  mov(eax, memd[ds, eax + 11]);         /* mov eax, [eax+0xb] */
            ii(0x100a_2c06, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_2c09, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100a_2c0d, 5);  sub(eax, 0xff);                       /* sub eax, 0xff */
            ii(0x100a_2c12, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100a_2c14, 2);  if(jle(0x100a_2c1f, 9)) goto l_0x100a_2c1f;/* jle 0x100a2c1f */
            ii(0x100a_2c16, 7);  mov(memd[ss, ebp - 12], 1);           /* mov dword [ebp-0xc], 0x1 */
            ii(0x100a_2c1d, 2);  jmp(0x100a_2c37, 0x18); goto l_0x100a_2c37;/* jmp 0x100a2c37 */
        l_0x100a_2c1f:
            ii(0x100a_2c1f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_2c22, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_2c25, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_2c28, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_2c2b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_2c2e, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x100a_2c31, 3);  sub(eax, memd[ss, ebp - 4]);          /* sub eax, [ebp-0x4] */
            ii(0x100a_2c34, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x100a_2c37:
            ii(0x100a_2c37, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_2c3a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_2c3c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_2c3d, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_2c3e, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_2c3f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_2c40, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_2c41, 1);  ret();                                /* ret */
        }
    }
}

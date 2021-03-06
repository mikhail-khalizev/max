using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_7f6c-575929f")]
        public void Method_100d_7f6c()
        {
            ii(0x100d_7f6c, 5);  push(0x38);                           /* push 0x38 */
            ii(0x100d_7f71, 5);  call(Definitions.sys_check_available_stack_size, 0x8_dddc);/* call 0x10165d52 */
            ii(0x100d_7f76, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_7f77, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_7f78, 1);  push(esi);                            /* push esi */
            ii(0x100d_7f79, 1);  push(edi);                            /* push edi */
            ii(0x100d_7f7a, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_7f7b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_7f7d, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_7f83, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_7f86, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_7f89, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_7f8c, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100d_7f8f, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_7f92, 1);  push(eax);                            /* push eax */
            ii(0x100d_7f93, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7f96, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x100d_7f99, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_7f9c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_7f9f, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100d_7fa2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_7fa5, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100d_7fa8, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x100d_7faa, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7fad, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100d_7fb0, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_7fb3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_7fb6, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100d_7fb9, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_7fbb, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100d_7fbd, 1);  push(eax);                            /* push eax */
            ii(0x100d_7fbe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7fc1, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_7fc4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_7fc7, 1);  push(eax);                            /* push eax */
            ii(0x100d_7fc8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7fcb, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100d_7fce, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_7fd1, 1);  push(eax);                            /* push eax */
            ii(0x100d_7fd2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7fd5, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_7fd8, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_7fdb, 1);  push(eax);                            /* push eax */
            ii(0x100d_7fdc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7fdf, 2);  push(memd[ds, eax]);                  /* push dword [eax] */
            ii(0x100d_7fe1, 5);  call(/* sys */ 0x1016_abbc, 0x9_2bd6);/* call 0x1016abbc */
            ii(0x100d_7fe6, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x100d_7fe9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_7feb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_7fec, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_7fed, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_7fee, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_7fef, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_7ff0, 1);  ret();                                /* ret */
        }
    }
}

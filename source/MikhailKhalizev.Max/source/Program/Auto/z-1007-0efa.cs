using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_0efa-6bc5cb8a")]
        public void Method_1007_0efa()
        {
            ii(0x1007_0efa, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1007_0eff, 5);  call(Definitions.sys_check_available_stack_size, 0xf_4e4e);/* call 0x10165d52 */
            ii(0x1007_0f04, 1);  push(esi);                            /* push esi */
            ii(0x1007_0f05, 1);  push(edi);                            /* push edi */
            ii(0x1007_0f06, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_0f07, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_0f09, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1007_0f0f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_0f12, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x1007_0f15, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x1007_0f18, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1007_0f1b, 7);  mov(memd[ss, ebp - 20], 1);           /* mov dword [ebp-0x14], 0x1 */
            ii(0x1007_0f22, 2);  jmp(0x1007_0f2a, 6); goto l_0x1007_0f2a;/* jmp 0x10070f2a */
        l_0x1007_0f24:
            ii(0x1007_0f24, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_0f27, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x1007_0f2a:
            ii(0x1007_0f2a, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_0f2d, 4);  cmp(ax, memw[ss, ebp + 16]);          /* cmp ax, [ebp+0x10] */
            ii(0x1007_0f31, 6);  if(jg(0x1007_101f, 0xe8)) goto l_0x1007_101f;/* jg 0x1007101f */
            ii(0x1007_0f37, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_0f3a, 3);  dec(memw[ds, eax]);                   /* dec word [eax] */
            ii(0x1007_0f3d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_0f40, 3);  dec(memw[ds, eax]);                   /* dec word [eax] */
            ii(0x1007_0f43, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_0f45, 1);  push(eax);                            /* push eax */
            ii(0x1007_0f46, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x1007_0f4a, 1);  push(eax);                            /* push eax */
            ii(0x1007_0f4b, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_0f4e, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1007_0f50, 3);  add(eax, memd[ss, ebp + 20]);         /* add eax, [ebp+0x14] */
            ii(0x1007_0f53, 1);  cwde();                               /* cwde */
            ii(0x1007_0f54, 1);  push(eax);                            /* push eax */
            ii(0x1007_0f55, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1007_0f58, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1007_0f5b, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_0f5e, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0f62, 5);  call(0x1007_07ed, -0x77a);            /* call 0x100707ed */
            ii(0x1007_0f67, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x1007_0f6a, 2);  if(jz(0x1007_0f78, 0xc)) goto l_0x1007_0f78;/* jz 0x10070f78 */
            ii(0x1007_0f6c, 7);  mov(memd[ss, ebp - 24], 1);           /* mov dword [ebp-0x18], 0x1 */
            ii(0x1007_0f73, 5);  jmp(0x1007_1026, 0xae); goto l_0x1007_1026;/* jmp 0x10071026 */
        l_0x1007_0f78:
            ii(0x1007_0f78, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1007_0f7d, 1);  push(eax);                            /* push eax */
            ii(0x1007_0f7e, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x1007_0f82, 1);  push(eax);                            /* push eax */
            ii(0x1007_0f83, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_0f86, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1007_0f88, 3);  add(eax, memd[ss, ebp + 20]);         /* add eax, [ebp+0x14] */
            ii(0x1007_0f8b, 1);  cwde();                               /* cwde */
            ii(0x1007_0f8c, 1);  push(eax);                            /* push eax */
            ii(0x1007_0f8d, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1007_0f90, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1007_0f93, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_0f96, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0f9a, 5);  call(0x1007_07ed, -0x7b2);            /* call 0x100707ed */
            ii(0x1007_0f9f, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x1007_0fa2, 2);  if(jz(0x1007_0fb0, 0xc)) goto l_0x1007_0fb0;/* jz 0x10070fb0 */
            ii(0x1007_0fa4, 7);  mov(memd[ss, ebp - 24], 1);           /* mov dword [ebp-0x18], 0x1 */
            ii(0x1007_0fab, 5);  jmp(0x1007_1026, 0x76); goto l_0x1007_1026;/* jmp 0x10071026 */
        l_0x1007_0fb0:
            ii(0x1007_0fb0, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x1007_0fb5, 1);  push(eax);                            /* push eax */
            ii(0x1007_0fb6, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x1007_0fba, 1);  push(eax);                            /* push eax */
            ii(0x1007_0fbb, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_0fbe, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1007_0fc0, 3);  add(eax, memd[ss, ebp + 20]);         /* add eax, [ebp+0x14] */
            ii(0x1007_0fc3, 1);  cwde();                               /* cwde */
            ii(0x1007_0fc4, 1);  push(eax);                            /* push eax */
            ii(0x1007_0fc5, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1007_0fc8, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1007_0fcb, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_0fce, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0fd2, 5);  call(0x1007_07ed, -0x7ea);            /* call 0x100707ed */
            ii(0x1007_0fd7, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x1007_0fda, 2);  if(jz(0x1007_0fe5, 9)) goto l_0x1007_0fe5;/* jz 0x10070fe5 */
            ii(0x1007_0fdc, 7);  mov(memd[ss, ebp - 24], 1);           /* mov dword [ebp-0x18], 0x1 */
            ii(0x1007_0fe3, 2);  jmp(0x1007_1026, 0x41); goto l_0x1007_1026;/* jmp 0x10071026 */
        l_0x1007_0fe5:
            ii(0x1007_0fe5, 5);  mov(eax, 3);                          /* mov eax, 0x3 */
            ii(0x1007_0fea, 1);  push(eax);                            /* push eax */
            ii(0x1007_0feb, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x1007_0fef, 1);  push(eax);                            /* push eax */
            ii(0x1007_0ff0, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_0ff3, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1007_0ff5, 3);  add(eax, memd[ss, ebp + 20]);         /* add eax, [ebp+0x14] */
            ii(0x1007_0ff8, 1);  cwde();                               /* cwde */
            ii(0x1007_0ff9, 1);  push(eax);                            /* push eax */
            ii(0x1007_0ffa, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1007_0ffd, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1007_1000, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_1003, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_1007, 5);  call(0x1007_07ed, -0x81f);            /* call 0x100707ed */
            ii(0x1007_100c, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x1007_100f, 2);  if(jz(0x1007_101a, 9)) goto l_0x1007_101a;/* jz 0x1007101a */
            ii(0x1007_1011, 7);  mov(memd[ss, ebp - 24], 1);           /* mov dword [ebp-0x18], 0x1 */
            ii(0x1007_1018, 2);  jmp(0x1007_1026, 0xc); goto l_0x1007_1026;/* jmp 0x10071026 */
        l_0x1007_101a:
            ii(0x1007_101a, 5);  jmp(0x1007_0f24, -0xfb); goto l_0x1007_0f24;/* jmp 0x10070f24 */
        l_0x1007_101f:
            ii(0x1007_101f, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1007_1026:
            ii(0x1007_1026, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_1029, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_102b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_102c, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_102d, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_102e, 3);  ret(0xc);                             /* ret 0xc */
        }
    }
}

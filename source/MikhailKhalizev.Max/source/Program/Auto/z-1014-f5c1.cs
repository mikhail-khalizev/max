using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f5c1-a51d2df7")]
        public void Method_1014_f5c1()
        {
            ii(0x1014_f5c1, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_f5c6, 5);  call(Definitions.sys_check_available_stack_size, 0x1_6787);/* call 0x10165d52 */
            ii(0x1014_f5cb, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_f5cc, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_f5cd, 1);  push(edx);                            /* push edx */
            ii(0x1014_f5ce, 1);  push(esi);                            /* push esi */
            ii(0x1014_f5cf, 1);  push(edi);                            /* push edi */
            ii(0x1014_f5d0, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_f5d1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_f5d3, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_f5d9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_f5dc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f5df, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1014_f5e3, 2);  if(jnz(0x1014_f5f6, 0x11)) goto l_0x1014_f5f6;/* jnz 0x1014f5f6 */
            ii(0x1014_f5e5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_f5e7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f5ea, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x1014_f5ed, 5);  call(0x1013_ad11, -0x1_48e1);         /* call 0x1013ad11 */
            ii(0x1014_f5f2, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_f5f4, 2);  if(jz(0x1014_f5f8, 2)) goto l_0x1014_f5f8;/* jz 0x1014f5f8 */
        l_0x1014_f5f6:
            ii(0x1014_f5f6, 2);  jmp(0x1014_f62b, 0x33); goto l_0x1014_f62b;/* jmp 0x1014f62b */
        l_0x1014_f5f8:
            ii(0x1014_f5f8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f5fb, 4);  cmp(memb[ds, eax + 62], 5);           /* cmp byte [eax+0x3e], 0x5 */
            ii(0x1014_f5ff, 2);  if(jz(0x1014_f60a, 9)) goto l_0x1014_f60a;/* jz 0x1014f60a */
            ii(0x1014_f601, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f604, 4);  cmp(memb[ds, eax + 62], 6);           /* cmp byte [eax+0x3e], 0x6 */
            ii(0x1014_f608, 2);  if(jnz(0x1014_f60c, 2)) goto l_0x1014_f60c;/* jnz 0x1014f60c */
        l_0x1014_f60a:
            ii(0x1014_f60a, 2);  jmp(0x1014_f60e, 2); goto l_0x1014_f60e;/* jmp 0x1014f60e */
        l_0x1014_f60c:
            ii(0x1014_f60c, 2);  jmp(0x1014_f62b, 0x1d); goto l_0x1014_f62b;/* jmp 0x1014f62b */
        l_0x1014_f60e:
            ii(0x1014_f60e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f611, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x1014_f614, 5);  call(0x1007_69d8, -0xd_8c41);         /* call 0x100769d8 */
            ii(0x1014_f619, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_f61c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f61f, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1014_f622, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_f625, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f628, 3);  call_abs(memd[ds, ebx + 32]);         /* call dword [ebx+0x20] */
        l_0x1014_f62b:
            ii(0x1014_f62b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_f62d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_f62e, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_f62f, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_f630, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_f631, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_f632, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_f633, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_18fd-613222b5")]
        public void my_strobj_reserve()
        {
            ii(0x1014_18fd, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_1902, 5);  call(Definitions.sys_check_available_stack_size, 0x2_444b);/* call 0x10165d52 */
            ii(0x1014_1907, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_1908, 1);  push(esi);                            /* push esi */
            ii(0x1014_1909, 1);  push(edi);                            /* push edi */
            ii(0x1014_190a, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_190b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_190d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_1913, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_1916, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_1919, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1014_191c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_191f, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_1922, 4);  cmp(ax, memw[ds, edx + 4]);           /* cmp ax, [edx+0x4] */
            ii(0x1014_1926, 6);  if(jz(0x1014_19c9, 0x9d)) goto l_0x1014_19c9;/* jz 0x101419c9 */
            ii(0x1014_192c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_192f, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_1932, 4);  mov(memw[ds, edx + 4], ax);           /* mov [edx+0x4], ax */
            ii(0x1014_1936, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1014_193a, 2);  if(jz(0x1014_199d, 0x61)) goto l_0x1014_199d;/* jz 0x1014199d */
            ii(0x1014_193c, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_1940, 1);  inc(eax);                             /* inc eax */
            ii(0x1014_1941, 5);  call(Definitions.sys_new_arr, 0x2_46ca);/* call 0x10166010 */
            ii(0x1014_1946, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_1949, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_194c, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_194f, 4);  cmp(ax, memw[ds, edx + 6]);           /* cmp ax, [edx+0x6] */
            ii(0x1014_1953, 2);  if(jge(0x1014_197c, 0x27)) goto l_0x1014_197c;/* jge 0x1014197c */
            ii(0x1014_1955, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1014_1959, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_195c, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1014_195e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_1961, 5);  call(Definitions.sys_strncpy, 0x3_057a);/* call 0x10171ee0 */
            ii(0x1014_1966, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_196a, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1014_196d, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x1014_1970, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_1973, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_1976, 4);  mov(memw[ds, edx + 6], ax);           /* mov [edx+0x6], ax */
            ii(0x1014_197a, 2);  jmp(0x1014_1989, 0xd); goto l_0x1014_1989;/* jmp 0x10141989 */
        l_0x1014_197c:
            ii(0x1014_197c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_197f, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1014_1981, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_1984, 5);  call(Definitions.sys_strcpy, 0x2_4546);/* call 0x10165ecf */
        l_0x1014_1989:
            ii(0x1014_1989, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_198c, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_198e, 5);  call(Definitions.sys_delete_arr, 0x2_4645);/* call 0x10165fd8 */
            ii(0x1014_1993, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_1996, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_1999, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
            ii(0x1014_199b, 2);  jmp(0x1014_19c9, 0x2c); goto l_0x1014_19c9;/* jmp 0x101419c9 */
        l_0x1014_199d:
            ii(0x1014_199d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_19a0, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_19a2, 5);  call(Definitions.sys_delete_arr, 0x2_4631);/* call 0x10165fd8 */
            ii(0x1014_19a7, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_19ab, 1);  inc(eax);                             /* inc eax */
            ii(0x1014_19ac, 5);  call(Definitions.sys_new_arr, 0x2_465f);/* call 0x10166010 */
            ii(0x1014_19b1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_19b3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_19b6, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1014_19b8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_19bb, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_19bd, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x1014_19c0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_19c3, 6);  mov(memw[ds, eax + 6], 0);            /* mov word [eax+0x6], 0x0 */
        l_0x1014_19c9:
            ii(0x1014_19c9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_19cb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_19cc, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_19cd, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_19ce, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_19cf, 1);  ret();                                /* ret */
        }
    }
}

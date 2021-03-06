using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_5150-fa4e5164")]
        public void Method_1010_5150()
        {
            ii(0x1010_5150, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1010_5155, 5);  call(Definitions.sys_check_available_stack_size, 0x6_0bf8);/* call 0x10165d52 */
            ii(0x1010_515a, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_515b, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_515c, 1);  push(edx);                            /* push edx */
            ii(0x1010_515d, 1);  push(esi);                            /* push esi */
            ii(0x1010_515e, 1);  push(edi);                            /* push edi */
            ii(0x1010_515f, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_5160, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_5162, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1010_5168, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x1010_516b:
            ii(0x1010_516b, 5);  mov(eax, 0x1388);                     /* mov eax, 0x1388 */
            ii(0x1010_5170, 5);  call(Definitions.sys_new_arr, 0x6_0e9b);/* call 0x10166010 */
            ii(0x1010_5175, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_5178, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_517c, 2);  if(jnz(0x1010_5187, 9)) goto l_0x1010_5187;/* jnz 0x10105187 */
            ii(0x1010_517e, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_5182, 5);  jmp(0x1010_5275, 0xee); goto l_0x1010_5275;/* jmp 0x10105275 */
        l_0x1010_5187:
            ii(0x1010_5187, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_518a, 3);  mov(edx, memd[ds, eax + 67]);         /* mov edx, [eax+0x43] */
            ii(0x1010_518d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_5190, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1010_5193, 3);  add(edx, memd[ss, ebp - 4]);          /* add edx, [ebp-0x4] */
            ii(0x1010_5196, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_5199, 3);  mov(memd[ds, edx + 71], eax);         /* mov [edx+0x47], eax */
            ii(0x1010_519c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_519f, 4);  inc(memw[ds, eax + 69]);              /* inc word [eax+0x45] */
            ii(0x1010_51a3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_51a6, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x1010_51a9:
            ii(0x1010_51a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_51ac, 5);  call(0x1010_4f1b, -0x296);            /* call 0x10104f1b */
            ii(0x1010_51b1, 2);  test(al, al);                         /* test al, al */
            ii(0x1010_51b3, 2);  if(jnz(0x1010_51e1, 0x2c)) goto l_0x1010_51e1;/* jnz 0x101051e1 */
            ii(0x1010_51b5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_51b8, 3);  mov(eax, memd[ds, eax + 67]);         /* mov eax, [eax+0x43] */
            ii(0x1010_51bb, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_51be, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_51c1, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1010_51c4, 3);  mov(eax, memd[ds, eax + 67]);         /* mov eax, [eax+0x43] */
            ii(0x1010_51c7, 3);  cmp(eax, memd[ss, ebp - 12]);         /* cmp eax, [ebp-0xc] */
            ii(0x1010_51ca, 2);  if(jz(0x1010_51d2, 6)) goto l_0x1010_51d2;/* jz 0x101051d2 */
            ii(0x1010_51cc, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1010_51d0, 2);  jmp(0x1010_51d6, 4); goto l_0x1010_51d6;/* jmp 0x101051d6 */
        l_0x1010_51d2:
            ii(0x1010_51d2, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1010_51d6:
            ii(0x1010_51d6, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1010_51d9, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1010_51dc, 5);  jmp(0x1010_5275, 0x94); goto l_0x1010_5275;/* jmp 0x10105275 */
        l_0x1010_51e1:
            ii(0x1010_51e1, 5);  mov(edx, StringDefinitions.Control20);/* mov edx, 0x101a32ee */
            ii(0x1010_51e6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_51e9, 3);  add(eax, 0x6f);                       /* add eax, 0x6f */
            ii(0x1010_51ec, 5);  call(Definitions.sys_strstr, 0x7_3e1f);/* call 0x10179010 */
            ii(0x1010_51f1, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_51f3, 2);  if(jnz(0x1010_5209, 0x14)) goto l_0x1010_5209;/* jnz 0x10105209 */
            ii(0x1010_51f5, 5);  mov(edx, StringDefinitions.Control21);/* mov edx, 0x101a32f0 */
            ii(0x1010_51fa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_51fd, 3);  add(eax, 0x6f);                       /* add eax, 0x6f */
            ii(0x1010_5200, 5);  call(Definitions.sys_strstr, 0x7_3e0b);/* call 0x10179010 */
            ii(0x1010_5205, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_5207, 2);  if(jz(0x1010_5232, 0x29)) goto l_0x1010_5232;/* jz 0x10105232 */
        l_0x1010_5209:
            ii(0x1010_5209, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_520c, 3);  mov(eax, memd[ds, eax + 67]);         /* mov eax, [eax+0x43] */
            ii(0x1010_520f, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_5212, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_5215, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1010_5218, 3);  mov(eax, memd[ds, eax + 67]);         /* mov eax, [eax+0x43] */
            ii(0x1010_521b, 3);  cmp(eax, memd[ss, ebp - 12]);         /* cmp eax, [ebp-0xc] */
            ii(0x1010_521e, 2);  if(jz(0x1010_5226, 6)) goto l_0x1010_5226;/* jz 0x10105226 */
            ii(0x1010_5220, 4);  mov(memb[ss, ebp - 20], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1010_5224, 2);  jmp(0x1010_522a, 4); goto l_0x1010_522a;/* jmp 0x1010522a */
        l_0x1010_5226:
            ii(0x1010_5226, 4);  mov(memb[ss, ebp - 20], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x1010_522a:
            ii(0x1010_522a, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x1010_522d, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1010_5230, 2);  jmp(0x1010_5275, 0x43); goto l_0x1010_5275;/* jmp 0x10105275 */
        l_0x1010_5232:
            ii(0x1010_5232, 5);  mov(edx, StringDefinitions.P);        /* mov edx, 0x101a32f2 */
            ii(0x1010_5237, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_523a, 3);  add(eax, 0x6f);                       /* add eax, 0x6f */
            ii(0x1010_523d, 5);  call(Definitions.sys_strstr, 0x7_3dce);/* call 0x10179010 */
            ii(0x1010_5242, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_5244, 2);  if(jnz(0x1010_5270, 0x2a)) goto l_0x1010_5270;/* jnz 0x10105270 */
            ii(0x1010_5246, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_5249, 3);  add(edx, 0x6f);                       /* add edx, 0x6f */
            ii(0x1010_524c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_524f, 5);  call(Definitions.sys_strcat, 0x6_0cdd);/* call 0x10165f31 */
            ii(0x1010_5254, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_5257, 3);  add(eax, 0x6f);                       /* add eax, 0x6f */
            ii(0x1010_525a, 5);  call(Definitions.sys_strlen, 0x6_cc68);/* call 0x10171ec7 */
            ii(0x1010_525f, 3);  sub(eax, 2);                          /* sub eax, 0x2 */
            ii(0x1010_5262, 3);  add(memd[ss, ebp - 12], eax);         /* add [ebp-0xc], eax */
            ii(0x1010_5265, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_5268, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x1010_526b, 5);  jmp(0x1010_51a9, -0xc7); goto l_0x1010_51a9;/* jmp 0x101051a9 */
        l_0x1010_5270:
            ii(0x1010_5270, 5);  jmp(0x1010_516b, -0x10a); goto l_0x1010_516b;/* jmp 0x1010516b */
        l_0x1010_5275:
            ii(0x1010_5275, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1010_5278, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_527a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_527b, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_527c, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_527d, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_527e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_527f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_5280, 1);  ret();                                /* ret */
        }
    }
}

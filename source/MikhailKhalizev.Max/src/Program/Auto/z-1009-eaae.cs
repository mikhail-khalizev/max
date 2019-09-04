using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_eaae-355f2369")]
        public void Method_1009_eaae()
        {
            ii(0x1009_eaae, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1009_eab3, 5);  call(Definitions.sys_check_available_stack_size, 0xc_729a);/* call 0x10165d52 */
            ii(0x1009_eab8, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_eab9, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_eaba, 1);  push(esi);                            /* push esi */
            ii(0x1009_eabb, 1);  push(edi);                            /* push edi */
            ii(0x1009_eabc, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_eabd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_eabf, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1009_eac5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_eac8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_eacb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_eace, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1009_ead1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_ead4, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1009_ead7, 4);  cmp(memb[ds, eax + 35], 0);           /* cmp byte [eax+0x23], 0x0 */
            ii(0x1009_eadb, 2);  if(jnz(0x1009_eae6, 9)) goto l_0x1009_eae6;/* jnz 0x1009eae6 */
            ii(0x1009_eadd, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_eae1, 5);  jmp(0x1009_eba0, 0xba); goto l_0x1009_eba0;/* jmp 0x1009eba0 */
        l_0x1009_eae6:
            ii(0x1009_eae6, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1009_eaed, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_eaf0, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_eaf3, 5);  call(0x1007_6338, -0x2_87c0);         /* call 0x10076338 */
            ii(0x1009_eaf8, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x1009_eafb, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_eafd, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1009_eaff, 5);  call(0x1007_64b8, -0x2_864c);         /* call 0x100764b8 */
            ii(0x1009_eb04, 2);  jmp(0x1009_eb0e, 8); goto l_0x1009_eb0e;/* jmp 0x1009eb0e */
        l_0x1009_eb06:
            ii(0x1009_eb06, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_eb09, 5);  call(0x1007_6bf8, -0x2_7f16);         /* call 0x10076bf8 */
        l_0x1009_eb0e:
            ii(0x1009_eb0e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_eb10, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_eb13, 5);  call(0x1013_ad71, 0x9_c259);          /* call 0x1013ad71 */
            ii(0x1009_eb18, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_eb1a, 2);  if(jz(0x1009_eb39, 0x1d)) goto l_0x1009_eb39;/* jz 0x1009eb39 */
            ii(0x1009_eb1c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_eb1f, 5);  call(0x1007_63a0, -0x2_8784);         /* call 0x100763a0 */
            ii(0x1009_eb24, 4);  mov(dx, memw[ds, eax + 8]);           /* mov dx, [eax+0x8] */
            ii(0x1009_eb28, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_eb2b, 4);  cmp(dx, memw[ds, eax + 8]);           /* cmp dx, [eax+0x8] */
            ii(0x1009_eb2f, 2);  if(jnz(0x1009_eb37, 6)) goto l_0x1009_eb37;/* jnz 0x1009eb37 */
            ii(0x1009_eb31, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_eb34, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1009_eb37:
            ii(0x1009_eb37, 2);  jmp(0x1009_eb06, -0x33); goto l_0x1009_eb06;/* jmp 0x1009eb06 */
        l_0x1009_eb39:
            ii(0x1009_eb39, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_eb3c, 5);  cmp(memw[ds, eax + 8], 0x32);         /* cmp word [eax+0x8], 0x32 */
            ii(0x1009_eb41, 2);  if(jz(0x1009_eb4d, 0xa)) goto l_0x1009_eb4d;/* jz 0x1009eb4d */
            ii(0x1009_eb43, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_eb46, 5);  cmp(memw[ds, eax + 8], 0x44);         /* cmp word [eax+0x8], 0x44 */
            ii(0x1009_eb4b, 2);  if(jnz(0x1009_eb72, 0x25)) goto l_0x1009_eb72;/* jnz 0x1009eb72 */
        l_0x1009_eb4d:
            ii(0x1009_eb4d, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_eb51, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1009_eb54, 2);  if(jge(0x1009_eb5c, 6)) goto l_0x1009_eb5c;/* jge 0x1009eb5c */
            ii(0x1009_eb56, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x1009_eb5a, 2);  jmp(0x1009_eb60, 4); goto l_0x1009_eb60;/* jmp 0x1009eb60 */
        l_0x1009_eb5c:
            ii(0x1009_eb5c, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1009_eb60:
            ii(0x1009_eb60, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1009_eb63, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1009_eb66, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_eb68, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_eb6b, 5);  call(0x1007_5f6c, -0x2_8c04);         /* call 0x10075f6c */
            ii(0x1009_eb70, 2);  jmp(0x1009_eba0, 0x2e); goto l_0x1009_eba0;/* jmp 0x1009eba0 */
        l_0x1009_eb72:
            ii(0x1009_eb72, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_eb76, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_eb78, 2);  if(jnz(0x1009_eb80, 6)) goto l_0x1009_eb80;/* jnz 0x1009eb80 */
            ii(0x1009_eb7a, 4);  mov(memb[ss, ebp - 28], 1);           /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1009_eb7e, 2);  jmp(0x1009_eb84, 4); goto l_0x1009_eb84;/* jmp 0x1009eb84 */
        l_0x1009_eb80:
            ii(0x1009_eb80, 4);  mov(memb[ss, ebp - 28], 0);           /* mov byte [ebp-0x1c], 0x0 */
        l_0x1009_eb84:
            ii(0x1009_eb84, 3);  mov(al, memb[ss, ebp - 28]);          /* mov al, [ebp-0x1c] */
            ii(0x1009_eb87, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1009_eb8a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_eb8c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_eb8f, 5);  call(0x1007_5f6c, -0x2_8c28);         /* call 0x10075f6c */
            ii(0x1009_eb94, 2);  jmp(0x1009_eba0, 0xa); goto l_0x1009_eba0;/* jmp 0x1009eba0 */
        //  ii(0x1009_eb96, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1009_eb98, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
        //  ii(0x1009_eb9b, 5);  call(0x1007_5f6c, -0x2_8c34);         /* call 0x10075f6c */
        l_0x1009_eba0:
            ii(0x1009_eba0, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1009_eba3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_eba5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_eba6, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_eba7, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_eba8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_eba9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_ebaa, 1);  ret();                                /* ret */
        }
    }
}

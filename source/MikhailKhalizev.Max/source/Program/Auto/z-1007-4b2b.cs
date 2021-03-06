using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4b2b-ec4a8b88")]
        public void Method_1007_4b2b()
        {
            ii(0x1007_4b2b, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1007_4b30, 5);  call(Definitions.sys_check_available_stack_size, 0xf_121d);/* call 0x10165d52 */
            ii(0x1007_4b35, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_4b36, 1);  push(esi);                            /* push esi */
            ii(0x1007_4b37, 1);  push(edi);                            /* push edi */
            ii(0x1007_4b38, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_4b39, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_4b3b, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1007_4b41, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_4b44, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_4b47, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1007_4b4a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_4b4d, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1007_4b50, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_4b53, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_4b56, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1007_4b5a, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_4b5d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_4b60, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1007_4b64, 2);  if(jz(0x1007_4b75, 0xf)) goto l_0x1007_4b75;/* jz 0x10074b75 */
            ii(0x1007_4b66, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_4b69, 4);  test(memb[ds, eax + 20], 1);          /* test byte [eax+0x14], 0x1 */
            ii(0x1007_4b6d, 2);  if(jnz(0x1007_4b75, 6)) goto l_0x1007_4b75;/* jnz 0x10074b75 */
            ii(0x1007_4b6f, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_4b73, 2);  jmp(0x1007_4bd4, 0x5f); goto l_0x1007_4bd4;/* jmp 0x10074bd4 */
        l_0x1007_4b75:
            ii(0x1007_4b75, 7);  test(memd[ss, ebp - 28], 0x40);       /* test dword [ebp-0x1c], 0x40 */
            ii(0x1007_4b7c, 2);  if(jz(0x1007_4b92, 0x14)) goto l_0x1007_4b92;/* jz 0x10074b92 */
            ii(0x1007_4b7e, 7);  test(memd[ss, ebp - 28], 0x1_0000);   /* test dword [ebp-0x1c], 0x10000 */
            ii(0x1007_4b85, 2);  if(jnz(0x1007_4b92, 0xb)) goto l_0x1007_4b92;/* jnz 0x10074b92 */
            ii(0x1007_4b87, 4);  and(memd[ss, ebp - 28], -0x41 /* 0xbf */);/* and dword [ebp-0x1c], 0xffffffbf */
            ii(0x1007_4b8b, 7);  or(memd[ss, ebp - 28], 0x100);        /* or dword [ebp-0x1c], 0x100 */
        l_0x1007_4b92:
            ii(0x1007_4b92, 5);  cmp(memw[ss, ebp - 20], 0xf);         /* cmp word [ebp-0x14], 0xf */
            ii(0x1007_4b97, 2);  if(jz(0x1007_4ba0, 7)) goto l_0x1007_4ba0;/* jz 0x10074ba0 */
            ii(0x1007_4b99, 5);  cmp(memw[ss, ebp - 20], 0x10);        /* cmp word [ebp-0x14], 0x10 */
            ii(0x1007_4b9e, 2);  if(jnz(0x1007_4baf, 0xf)) goto l_0x1007_4baf;/* jnz 0x10074baf */
        l_0x1007_4ba0:
            ii(0x1007_4ba0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_4ba3, 5);  call(0x1007_611c, 0x1574);            /* call 0x1007611c */
            ii(0x1007_4ba8, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1007_4bac, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x1007_4baf:
            ii(0x1007_4baf, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_4bb2, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_4bb5, 5);  call(0x1007_5e64, 0x12aa);            /* call 0x10075e64 */
            ii(0x1007_4bba, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1007_4bbc, 3);  mov(ebx, memd[ss, ebp - 28]);         /* mov ebx, [ebp-0x1c] */
            ii(0x1007_4bbf, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1007_4bc3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_4bc6, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_4bc9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_4bcc, 5);  call(0x1007_4955, -0x27c);            /* call 0x10074955 */
            ii(0x1007_4bd1, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
        l_0x1007_4bd4:
            ii(0x1007_4bd4, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1007_4bd7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_4bd9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_4bda, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_4bdb, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_4bdc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_4bdd, 1);  ret();                                /* ret */
        }
    }
}

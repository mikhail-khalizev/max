using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_2abe-92b06733")]
        public void Method_1008_2abe()
        {
            ii(0x1008_2abe, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1008_2ac3, 5);  call(Definitions.sys_check_available_stack_size, 0xe_328a);/* call 0x10165d52 */
            ii(0x1008_2ac8, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_2ac9, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_2aca, 1);  push(esi);                            /* push esi */
            ii(0x1008_2acb, 1);  push(edi);                            /* push edi */
            ii(0x1008_2acc, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_2acd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_2acf, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1008_2ad5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_2ad8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_2adb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2ade, 5);  cmp(memw[ds, eax + 8], 0x4f);         /* cmp word [eax+0x8], 0x4f */
            ii(0x1008_2ae3, 2);  if(jz(0x1008_2aef, 0xa)) goto l_0x1008_2aef;/* jz 0x10082aef */
            ii(0x1008_2ae5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2ae8, 5);  cmp(memw[ds, eax + 8], 0x32);         /* cmp word [eax+0x8], 0x32 */
            ii(0x1008_2aed, 2);  if(jnz(0x1008_2af1, 2)) goto l_0x1008_2af1;/* jnz 0x10082af1 */
        l_0x1008_2aef:
            ii(0x1008_2aef, 2);  jmp(0x1008_2afb, 0xa); goto l_0x1008_2afb;/* jmp 0x10082afb */
        l_0x1008_2af1:
            ii(0x1008_2af1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2af4, 5);  cmp(memw[ds, eax + 8], 0x3a);         /* cmp word [eax+0x8], 0x3a */
            ii(0x1008_2af9, 2);  if(jnz(0x1008_2afd, 2)) goto l_0x1008_2afd;/* jnz 0x10082afd */
        l_0x1008_2afb:
            ii(0x1008_2afb, 2);  jmp(0x1008_2b07, 0xa); goto l_0x1008_2b07;/* jmp 0x10082b07 */
        l_0x1008_2afd:
            ii(0x1008_2afd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2b00, 5);  cmp(memw[ds, eax + 8], 0x44);         /* cmp word [eax+0x8], 0x44 */
            ii(0x1008_2b05, 2);  if(jnz(0x1008_2b09, 2)) goto l_0x1008_2b09;/* jnz 0x10082b09 */
        l_0x1008_2b07:
            ii(0x1008_2b07, 2);  jmp(0x1008_2b0f, 6); goto l_0x1008_2b0f;/* jmp 0x10082b0f */
        l_0x1008_2b09:
            ii(0x1008_2b09, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_2b0d, 2);  jmp(0x1008_2b6d, 0x5e); goto l_0x1008_2b6d;/* jmp 0x10082b6d */
        l_0x1008_2b0f:
            ii(0x1008_2b0f, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x1008_2b12, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1008_2b15, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_2b18, 5);  call(0x1008_2de2, 0x2c5);             /* call 0x10082de2 */
            ii(0x1008_2b1d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2b20, 5);  cmp(memw[ds, eax + 8], 0x4f);         /* cmp word [eax+0x8], 0x4f */
            ii(0x1008_2b25, 2);  if(jnz(0x1008_2b4b, 0x24)) goto l_0x1008_2b4b;/* jnz 0x10082b4b */
            ii(0x1008_2b27, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2b2a, 5);  call(0x1007_623c, -0xc8f3);           /* call 0x1007623c */
            ii(0x1008_2b2f, 4);  mov(ax, memw[ds, eax + 23]);          /* mov ax, [eax+0x17] */
            ii(0x1008_2b33, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1008_2b37, 2);  if(jl(0x1008_2b3f, 6)) goto l_0x1008_2b3f;/* jl 0x10082b3f */
            ii(0x1008_2b39, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x1008_2b3d, 2);  jmp(0x1008_2b43, 4); goto l_0x1008_2b43;/* jmp 0x10082b43 */
        l_0x1008_2b3f:
            ii(0x1008_2b3f, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1008_2b43:
            ii(0x1008_2b43, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1008_2b46, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1008_2b49, 2);  jmp(0x1008_2b6d, 0x22); goto l_0x1008_2b6d;/* jmp 0x10082b6d */
        l_0x1008_2b4b:
            ii(0x1008_2b4b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2b4e, 5);  call(0x1007_623c, -0xc917);           /* call 0x1007623c */
            ii(0x1008_2b53, 4);  mov(ax, memw[ds, eax + 23]);          /* mov ax, [eax+0x17] */
            ii(0x1008_2b57, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x1008_2b5b, 2);  if(jl(0x1008_2b63, 6)) goto l_0x1008_2b63;/* jl 0x10082b63 */
            ii(0x1008_2b5d, 4);  mov(memb[ss, ebp - 28], 1);           /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1008_2b61, 2);  jmp(0x1008_2b67, 4); goto l_0x1008_2b67;/* jmp 0x10082b67 */
        l_0x1008_2b63:
            ii(0x1008_2b63, 4);  mov(memb[ss, ebp - 28], 0);           /* mov byte [ebp-0x1c], 0x0 */
        l_0x1008_2b67:
            ii(0x1008_2b67, 3);  mov(al, memb[ss, ebp - 28]);          /* mov al, [ebp-0x1c] */
            ii(0x1008_2b6a, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
        l_0x1008_2b6d:
            ii(0x1008_2b6d, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_2b70, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_2b72, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_2b73, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_2b74, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_2b75, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_2b76, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_2b77, 1);  ret();                                /* ret */
        }
    }
}

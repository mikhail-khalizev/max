using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_3aa6-669ec18a")]
        public void Method_1007_3aa6()
        {
            ii(0x1007_3aa6, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1007_3aab, 5);  call(Definitions.sys_check_available_stack_size, 0xf_22a2);/* call 0x10165d52 */
            ii(0x1007_3ab0, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_3ab1, 1);  push(esi);                            /* push esi */
            ii(0x1007_3ab2, 1);  push(edi);                            /* push edi */
            ii(0x1007_3ab3, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_3ab4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_3ab6, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1007_3abc, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_3abf, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_3ac2, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1007_3ac5, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_3ac9, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_3acb, 2);  if(jl(0x1007_3ad9, 0xc)) goto l_0x1007_3ad9;/* jl 0x10073ad9 */
            ii(0x1007_3acd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_3ad0, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1007_3ad7, 2);  if(jl(0x1007_3adb, 2)) goto l_0x1007_3adb;/* jl 0x10073adb */
        l_0x1007_3ad9:
            ii(0x1007_3ad9, 2);  jmp(0x1007_3ae3, 8); goto l_0x1007_3ae3;/* jmp 0x10073ae3 */
        l_0x1007_3adb:
            ii(0x1007_3adb, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_3adf, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_3ae1, 2);  if(jge(0x1007_3ae5, 2)) goto l_0x1007_3ae5;/* jge 0x10073ae5 */
        l_0x1007_3ae3:
            ii(0x1007_3ae3, 2);  jmp(0x1007_3af1, 0xc); goto l_0x1007_3af1;/* jmp 0x10073af1 */
        l_0x1007_3ae5:
            ii(0x1007_3ae5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_3ae8, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1007_3aef, 2);  if(jl(0x1007_3afd, 0xc)) goto l_0x1007_3afd;/* jl 0x10073afd */
        l_0x1007_3af1:
            ii(0x1007_3af1, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_3af8, 5);  jmp(0x1007_3c0e, 0x111); goto l_0x1007_3c0e;/* jmp 0x10073c0e */
        l_0x1007_3afd:
            ii(0x1007_3afd, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1007_3b01, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1007_3b05, 5);  mov(eax, 0x101c_39b8);                /* mov eax, 0x101c39b8 */
            ii(0x1007_3b0a, 5);  call(0x1010_3541, 0x8_fa32);          /* call 0x10103541 */
            ii(0x1007_3b0f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_3b11, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3b14, 5);  call(0x1007_64b8, 0x299f);            /* call 0x100764b8 */
            ii(0x1007_3b19, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1007_3b20:
            ii(0x1007_3b20, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_3b22, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3b25, 5);  call(0x1013_ad71, 0xc_7247);          /* call 0x1013ad71 */
            ii(0x1007_3b2a, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_3b2c, 6);  if(jz(0x1007_3bcd, 0x9b)) goto l_0x1007_3bcd;/* jz 0x10073bcd */
            ii(0x1007_3b32, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3b35, 5);  call(0x1007_63a0, 0x2866);            /* call 0x100763a0 */
            ii(0x1007_3b3a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_3b3c, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1007_3b3f, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_3b43, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_3b45, 2);  if(jnz(0x1007_3b55, 0xe)) goto l_0x1007_3b55;/* jnz 0x10073b55 */
            ii(0x1007_3b47, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3b4a, 5);  call(0x1007_63a0, 0x2851);            /* call 0x100763a0 */
            ii(0x1007_3b4f, 4);  test(memb[ds, eax + 20], 0x40);       /* test byte [eax+0x14], 0x40 */
            ii(0x1007_3b53, 2);  if(jnz(0x1007_3b57, 2)) goto l_0x1007_3b57;/* jnz 0x10073b57 */
        l_0x1007_3b55:
            ii(0x1007_3b55, 2);  jmp(0x1007_3b65, 0xe); goto l_0x1007_3b65;/* jmp 0x10073b65 */
        l_0x1007_3b57:
            ii(0x1007_3b57, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3b5a, 5);  call(0x1007_63a0, 0x2841);            /* call 0x100763a0 */
            ii(0x1007_3b5f, 4);  test(memb[ds, eax + 20], 1);          /* test byte [eax+0x14], 0x1 */
            ii(0x1007_3b63, 2);  if(jz(0x1007_3b67, 2)) goto l_0x1007_3b67;/* jz 0x10073b67 */
        l_0x1007_3b65:
            ii(0x1007_3b65, 2);  jmp(0x1007_3b75, 0xe); goto l_0x1007_3b75;/* jmp 0x10073b75 */
        l_0x1007_3b67:
            ii(0x1007_3b67, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3b6a, 5);  call(0x1007_63a0, 0x2831);            /* call 0x100763a0 */
            ii(0x1007_3b6f, 4);  test(memb[ds, eax + 18], 1);          /* test byte [eax+0x12], 0x1 */
            ii(0x1007_3b73, 2);  if(jz(0x1007_3b77, 2)) goto l_0x1007_3b77;/* jz 0x10073b77 */
        l_0x1007_3b75:
            ii(0x1007_3b75, 2);  jmp(0x1007_3b86, 0xf); goto l_0x1007_3b86;/* jmp 0x10073b86 */
        l_0x1007_3b77:
            ii(0x1007_3b77, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3b7a, 5);  call(0x1007_63a0, 0x2821);            /* call 0x100763a0 */
            ii(0x1007_3b7f, 5);  cmp(memw[ds, eax + 8], 0x16);         /* cmp word [eax+0x8], 0x16 */
            ii(0x1007_3b84, 2);  if(jnz(0x1007_3b88, 2)) goto l_0x1007_3b88;/* jnz 0x10073b88 */
        l_0x1007_3b86:
            ii(0x1007_3b86, 2);  jmp(0x1007_3b96, 0xe); goto l_0x1007_3b96;/* jmp 0x10073b96 */
        l_0x1007_3b88:
            ii(0x1007_3b88, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3b8b, 5);  call(0x1007_63a0, 0x2810);            /* call 0x100763a0 */
            ii(0x1007_3b90, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_3b94, 2);  if(jnz(0x1007_3b98, 2)) goto l_0x1007_3b98;/* jnz 0x10073b98 */
        l_0x1007_3b96:
            ii(0x1007_3b96, 2);  jmp(0x1007_3bb1, 0x19); goto l_0x1007_3bb1;/* jmp 0x10073bb1 */
        l_0x1007_3b98:
            ii(0x1007_3b98, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3b9b, 5);  call(0x1007_63a0, 0x2800);            /* call 0x100763a0 */
            ii(0x1007_3ba0, 5);  call(0x1007_6154, 0x25af);            /* call 0x10076154 */
            ii(0x1007_3ba5, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x1007_3baa, 5);  cmp(eax, 0xffff);                     /* cmp eax, 0xffff */
            ii(0x1007_3baf, 2);  if(jnz(0x1007_3bb3, 2)) goto l_0x1007_3bb3;/* jnz 0x10073bb3 */
        l_0x1007_3bb1:
            ii(0x1007_3bb1, 2);  jmp(0x1007_3bc0, 0xd); goto l_0x1007_3bc0;/* jmp 0x10073bc0 */
        l_0x1007_3bb3:
            ii(0x1007_3bb3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3bb6, 5);  call(0x1007_6408, 0x284d);            /* call 0x10076408 */
            ii(0x1007_3bbb, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_3bbe, 2);  jmp(0x1007_3bcd, 0xd); goto l_0x1007_3bcd;/* jmp 0x10073bcd */
        l_0x1007_3bc0:
            ii(0x1007_3bc0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3bc3, 5);  call(0x1007_6bf8, 0x3030);            /* call 0x10076bf8 */
            ii(0x1007_3bc8, 5);  jmp(0x1007_3b20, -0xad); goto l_0x1007_3b20;/* jmp 0x10073b20 */
        l_0x1007_3bcd:
            ii(0x1007_3bcd, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1007_3bd1, 2);  if(jz(0x1007_3bf2, 0x1f)) goto l_0x1007_3bf2;/* jz 0x10073bf2 */
            ii(0x1007_3bd3, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_3bd6, 5);  cmp(memw[ds, eax + 8], 0xf);          /* cmp word [eax+0x8], 0xf */
            ii(0x1007_3bdb, 2);  if(jz(0x1007_3be7, 0xa)) goto l_0x1007_3be7;/* jz 0x10073be7 */
            ii(0x1007_3bdd, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_3be0, 5);  cmp(memw[ds, eax + 8], 0x10);         /* cmp word [eax+0x8], 0x10 */
            ii(0x1007_3be5, 2);  if(jnz(0x1007_3bf2, 0xb)) goto l_0x1007_3bf2;/* jnz 0x10073bf2 */
        l_0x1007_3be7:
            ii(0x1007_3be7, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_3bea, 5);  call(0x1007_611c, 0x252d);            /* call 0x1007611c */
            ii(0x1007_3bef, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1007_3bf2:
            ii(0x1007_3bf2, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_3bf5, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_3bf8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_3bfa, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3bfd, 5);  call(0x1007_5f6c, 0x236a);            /* call 0x10075f6c */
            ii(0x1007_3c02, 2);  jmp(0x1007_3c0e, 0xa); goto l_0x1007_3c0e;/* jmp 0x10073c0e */
        //  ii(0x1007_3c04, 10);  Недостижимый код.
        l_0x1007_3c0e:
            ii(0x1007_3c0e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_3c11, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_3c13, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_3c14, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_3c15, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_3c16, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_3c17, 1);  ret();                                /* ret */
        }
    }
}

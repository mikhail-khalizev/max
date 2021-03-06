using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_3c12-593cae34")]
        public void Method_1011_3c12()
        {
            ii(0x1011_3c12, 5);  push(0x44);                           /* push 0x44 */
            ii(0x1011_3c17, 5);  call(Definitions.sys_check_available_stack_size, 0x5_2136);/* call 0x10165d52 */
            ii(0x1011_3c1c, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_3c1d, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_3c1e, 1);  push(edx);                            /* push edx */
            ii(0x1011_3c1f, 1);  push(esi);                            /* push esi */
            ii(0x1011_3c20, 1);  push(edi);                            /* push edi */
            ii(0x1011_3c21, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_3c22, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_3c24, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x1011_3c2a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_3c2d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_3c30, 7);  cmp(memd[ds, eax + 406], 0);          /* cmp dword [eax+0x196], 0x0 */
            ii(0x1011_3c37, 2);  if(jz(0x1011_3c66, 0x2d)) goto l_0x1011_3c66;/* jz 0x10113c66 */
            ii(0x1011_3c39, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_3c3c, 6);  mov(eax, memd[ds, eax + 406]);        /* mov eax, [eax+0x196] */
            ii(0x1011_3c42, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_3c45, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_3c49, 2);  if(jz(0x1011_3c5f, 0x14)) goto l_0x1011_3c5f;/* jz 0x10113c5f */
            ii(0x1011_3c4b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_3c4d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_3c50, 5);  call(Definitions.my_dtor_d6, -0x2_8b7e);/* call 0x100eb0d7 */
            ii(0x1011_3c55, 5);  call(Definitions.sys_delete, 0x5_230a);/* call 0x10165f64 */
            ii(0x1011_3c5a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_3c5d, 2);  jmp(0x1011_3c66, 7); goto l_0x1011_3c66;/* jmp 0x10113c66 */
        l_0x1011_3c5f:
            ii(0x1011_3c5f, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1011_3c66:
            ii(0x1011_3c66, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_3c69, 7);  cmp(memd[ds, eax + 410], 0);          /* cmp dword [eax+0x19a], 0x0 */
            ii(0x1011_3c70, 2);  if(jz(0x1011_3c9f, 0x2d)) goto l_0x1011_3c9f;/* jz 0x10113c9f */
            ii(0x1011_3c72, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_3c75, 6);  mov(eax, memd[ds, eax + 410]);        /* mov eax, [eax+0x19a] */
            ii(0x1011_3c7b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_3c7e, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_3c82, 2);  if(jz(0x1011_3c98, 0x14)) goto l_0x1011_3c98;/* jz 0x10113c98 */
            ii(0x1011_3c84, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_3c86, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_3c89, 5);  call(Definitions.my_dtor_d6, -0x2_8bb7);/* call 0x100eb0d7 */
            ii(0x1011_3c8e, 5);  call(Definitions.sys_delete, 0x5_22d1);/* call 0x10165f64 */
            ii(0x1011_3c93, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_3c96, 2);  jmp(0x1011_3c9f, 7); goto l_0x1011_3c9f;/* jmp 0x10113c9f */
        l_0x1011_3c98:
            ii(0x1011_3c98, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1011_3c9f:
            ii(0x1011_3c9f, 7);  mov(memd[ss, ebp - 8], 0x18);         /* mov dword [ebp-0x8], 0x18 */
        l_0x1011_3ca6:
            ii(0x1011_3ca6, 3);  dec(memd[ss, ebp - 8]);               /* dec dword [ebp-0x8] */
            ii(0x1011_3ca9, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_3cae, 2);  if(jz(0x1011_3cf3, 0x43)) goto l_0x1011_3cf3;/* jz 0x10113cf3 */
            ii(0x1011_3cb0, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_3cb4, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_3cb7, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_3cba, 4);  cmp(memd[ds, eax + 22], 0);           /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_3cbe, 2);  if(jz(0x1011_3cf1, 0x31)) goto l_0x1011_3cf1;/* jz 0x10113cf1 */
            ii(0x1011_3cc0, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_3cc4, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_3cc7, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_3cca, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1011_3ccd, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_3cd0, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1011_3cd4, 2);  if(jz(0x1011_3cea, 0x14)) goto l_0x1011_3cea;/* jz 0x10113cea */
            ii(0x1011_3cd6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_3cd8, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_3cdb, 5);  call(Definitions.my_dtor_d2, -0x4_57a8);/* call 0x100ce538 */
            ii(0x1011_3ce0, 5);  call(Definitions.sys_delete, 0x5_227f);/* call 0x10165f64 */
            ii(0x1011_3ce5, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_3ce8, 2);  jmp(0x1011_3cf1, 7); goto l_0x1011_3cf1;/* jmp 0x10113cf1 */
        l_0x1011_3cea:
            ii(0x1011_3cea, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1011_3cf1:
            ii(0x1011_3cf1, 2);  jmp(0x1011_3ca6, -0x4d); goto l_0x1011_3ca6;/* jmp 0x10113ca6 */
        l_0x1011_3cf3:
            ii(0x1011_3cf3, 7);  mov(memd[ss, ebp - 8], 0xe);          /* mov dword [ebp-0x8], 0xe */
        l_0x1011_3cfa:
            ii(0x1011_3cfa, 3);  dec(memd[ss, ebp - 8]);               /* dec dword [ebp-0x8] */
            ii(0x1011_3cfd, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_3d02, 2);  if(jz(0x1011_3d4d, 0x49)) goto l_0x1011_3d4d;/* jz 0x10113d4d */
            ii(0x1011_3d04, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_3d08, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_3d0b, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_3d0e, 7);  cmp(memd[ds, eax + 1437], 0);         /* cmp dword [eax+0x59d], 0x0 */
            ii(0x1011_3d15, 2);  if(jz(0x1011_3d4b, 0x34)) goto l_0x1011_3d4b;/* jz 0x10113d4b */
            ii(0x1011_3d17, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_3d1b, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_3d1e, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_3d21, 6);  mov(eax, memd[ds, eax + 1437]);       /* mov eax, [eax+0x59d] */
            ii(0x1011_3d27, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_3d2a, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1011_3d2e, 2);  if(jz(0x1011_3d44, 0x14)) goto l_0x1011_3d44;/* jz 0x10113d44 */
            ii(0x1011_3d30, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_3d32, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_3d35, 5);  call(Definitions.my_dtor_d3, -0x3_c007);/* call 0x100d7d33 */
            ii(0x1011_3d3a, 5);  call(Definitions.sys_delete, 0x5_2225);/* call 0x10165f64 */
            ii(0x1011_3d3f, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_3d42, 2);  jmp(0x1011_3d4b, 7); goto l_0x1011_3d4b;/* jmp 0x10113d4b */
        l_0x1011_3d44:
            ii(0x1011_3d44, 7);  mov(memd[ss, ebp - 40], 0);           /* mov dword [ebp-0x28], 0x0 */
        l_0x1011_3d4b:
            ii(0x1011_3d4b, 2);  jmp(0x1011_3cfa, -0x53); goto l_0x1011_3cfa;/* jmp 0x10113cfa */
        l_0x1011_3d4d:
            ii(0x1011_3d4d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_3d4f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_3d50, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_3d51, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_3d52, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_3d53, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_3d54, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_3d55, 1);  ret();                                /* ret */
        }
    }
}

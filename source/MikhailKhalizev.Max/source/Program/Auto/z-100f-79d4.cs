using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_79d4-9e0fce02")]
        public void Method_100f_79d4()
        {
            ii(0x100f_79d4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100f_79d9, 5);  call(Definitions.sys_check_available_stack_size, 0x6_e374);/* call 0x10165d52 */
            ii(0x100f_79de, 1);  push(esi);                            /* push esi */
            ii(0x100f_79df, 1);  push(edi);                            /* push edi */
            ii(0x100f_79e0, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_79e1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_79e3, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100f_79e9, 3);  mov(memb[ss, ebp - 4], al);           /* mov [ebp-0x4], al */
            ii(0x100f_79ec, 3);  mov(memb[ss, ebp - 8], dl);           /* mov [ebp-0x8], dl */
            ii(0x100f_79ef, 3);  mov(memd[ss, ebp - 16], ebx);         /* mov [ebp-0x10], ebx */
            ii(0x100f_79f2, 3);  mov(memd[ss, ebp - 12], ecx);         /* mov [ebp-0xc], ecx */
            ii(0x100f_79f5, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_79f7, 5);  call(0x100f_448c, -0x3570);           /* call 0x100f448c */
            ii(0x100f_79fc, 4);  cmp(memb[ss, ebp - 4], 0x1e);         /* cmp byte [ebp-0x4], 0x1e */
            ii(0x100f_7a00, 2);  if(jnz(0x100f_7a6d, 0x6b)) goto l_0x100f_7a6d;/* jnz 0x100f7a6d */
            ii(0x100f_7a02, 5);  call(0x1007_6034, -0x8_19d3);         /* call 0x10076034 */
            ii(0x100f_7a07, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x100f_7a09, 2);  mov(cl, al);                          /* mov cl, al */
            ii(0x100f_7a0b, 4);  movsx(ebx, memw[ss, ebp + 16]);       /* movsx ebx, word [ebp+0x10] */
            ii(0x100f_7a0f, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100f_7a13, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7a16, 5);  call(0x1007_4c30, -0x8_2deb);         /* call 0x10074c30 */
            ii(0x100f_7a1b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_7a1e, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100f_7a22, 2);  if(jnz(0x100f_7a55, 0x31)) goto l_0x100f_7a55;/* jnz 0x100f7a55 */
            ii(0x100f_7a24, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7a27, 4);  cmp(memb[ds, eax + 80], 0);           /* cmp byte [eax+0x50], 0x0 */
            ii(0x100f_7a2b, 2);  if(jz(0x100f_7a50, 0x23)) goto l_0x100f_7a50;/* jz 0x100f7a50 */
            ii(0x100f_7a2d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_7a30, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_7a33, 4);  mov(memw[ds, edx + 65], ax);          /* mov [edx+0x41], ax */
            ii(0x100f_7a37, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100f_7a3a, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_7a3d, 4);  mov(memw[ds, edx + 67], ax);          /* mov [edx+0x43], ax */
            ii(0x100f_7a41, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100f_7a43, 5);  mov(edx, 3);                          /* mov edx, 0x3 */
            ii(0x100f_7a48, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7a4b, 5);  call(0x1016_3053, 0x6_b603);          /* call 0x10163053 */
        l_0x100f_7a50:
            ii(0x100f_7a50, 5);  jmp(0x100f_7b03, 0xae); goto l_0x100f_7b03;/* jmp 0x100f7b03 */
        l_0x100f_7a55:
            ii(0x100f_7a55, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_7a58, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7a5b, 5);  call(0x1007_60ac, -0x8_19b4);         /* call 0x100760ac */
            ii(0x100f_7a60, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_7a62, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7a65, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x100f_7a68, 5);  call(0x1007_6a34, -0x8_1039);         /* call 0x10076a34 */
        l_0x100f_7a6d:
            ii(0x100f_7a6d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_7a70, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_7a73, 4);  mov(memw[ds, edx + 65], ax);          /* mov [edx+0x41], ax */
            ii(0x100f_7a77, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100f_7a7a, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_7a7d, 4);  mov(memw[ds, edx + 67], ax);          /* mov [edx+0x43], ax */
            ii(0x100f_7a81, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7a84, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100f_7a88, 2);  if(jz(0x100f_7a93, 9)) goto l_0x100f_7a93;/* jz 0x100f7a93 */
            ii(0x100f_7a8a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7a8d, 4);  cmp(memb[ds, eax + 61], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x100f_7a91, 2);  if(jnz(0x100f_7a95, 2)) goto l_0x100f_7a95;/* jnz 0x100f7a95 */
        l_0x100f_7a93:
            ii(0x100f_7a93, 2);  jmp(0x100f_7a9e, 9); goto l_0x100f_7a9e;/* jmp 0x100f7a9e */
        l_0x100f_7a95:
            ii(0x100f_7a95, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7a98, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x100f_7a9c, 2);  if(jnz(0x100f_7ab6, 0x18)) goto l_0x100f_7ab6;/* jnz 0x100f7ab6 */
        l_0x100f_7a9e:
            ii(0x100f_7a9e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7aa1, 3);  mov(dl, memb[ds, eax + 63]);          /* mov dl, [eax+0x3f] */
            ii(0x100f_7aa4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7aa7, 3);  mov(memb[ds, eax + 61], dl);          /* mov [eax+0x3d], dl */
            ii(0x100f_7aaa, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7aad, 3);  mov(dl, memb[ds, eax + 64]);          /* mov dl, [eax+0x40] */
            ii(0x100f_7ab0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7ab3, 3);  mov(memb[ds, eax + 62], dl);          /* mov [eax+0x3e], dl */
        l_0x100f_7ab6:
            ii(0x100f_7ab6, 4);  cmp(memb[ss, ebp - 4], 0x1b);         /* cmp byte [ebp-0x4], 0x1b */
            ii(0x100f_7aba, 2);  if(jnz(0x100f_7ac4, 8)) goto l_0x100f_7ac4;/* jnz 0x100f7ac4 */
            ii(0x100f_7abc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7abf, 5);  call(0x1014_b6bd, 0x5_3bf9);          /* call 0x1014b6bd */
        l_0x100f_7ac4:
            ii(0x100f_7ac4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7ac7, 4);  mov(memb[ds, eax + 92], 0);           /* mov byte [eax+0x5c], 0x0 */
            ii(0x100f_7acb, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7ace, 5);  call(0x1015_287d, 0x5_adaa);          /* call 0x1015287d */
            ii(0x100f_7ad3, 4);  movsx(ebx, memb[ss, ebp - 8]);        /* movsx ebx, byte [ebp-0x8] */
            ii(0x100f_7ad7, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x100f_7adb, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7ade, 5);  call(0x1016_3053, 0x6_b570);          /* call 0x10163053 */
            ii(0x100f_7ae3, 5);  mov(edx, 0x101c_37bc);                /* mov edx, 0x101c37bc */
            ii(0x100f_7ae8, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7aeb, 5);  call(0x1007_6d98, -0x8_0d58);         /* call 0x10076d98 */
            ii(0x100f_7af0, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_7af2, 2);  if(jz(0x100f_7b03, 0xf)) goto l_0x100f_7b03;/* jz 0x100f7b03 */
            ii(0x100f_7af4, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_7af9, 5);  call(0x1007_65d0, -0x8_152e);         /* call 0x100765d0 */
            ii(0x100f_7afe, 5);  call(0x1010_094d, 0x8e4a);            /* call 0x1010094d */
        l_0x100f_7b03:
            ii(0x100f_7b03, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_7b05, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_7b06, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_7b07, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_7b08, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}

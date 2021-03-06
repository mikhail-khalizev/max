using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_3d99-8c6d217")]
        public void Method_1015_3d99()
        {
            ii(0x1015_3d99, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1015_3d9e, 5);  call(Definitions.sys_check_available_stack_size, 0x1_1faf);/* call 0x10165d52 */
            ii(0x1015_3da3, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_3da4, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_3da5, 1);  push(edx);                            /* push edx */
            ii(0x1015_3da6, 1);  push(esi);                            /* push esi */
            ii(0x1015_3da7, 1);  push(edi);                            /* push edi */
            ii(0x1015_3da8, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_3da9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_3dab, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1015_3db1, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_3db4, 7);  cmp(memb[ds, 0x101c_947d], 0);        /* cmp byte [0x101c947d], 0x0 */
            ii(0x1015_3dbb, 2);  if(jz(0x1015_3dc4, 7)) goto l_0x1015_3dc4;/* jz 0x10153dc4 */
            ii(0x1015_3dbd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3dc0, 4);  mov(memb[ds, eax + 95], 0);           /* mov byte [eax+0x5f], 0x0 */
        l_0x1015_3dc4:
            ii(0x1015_3dc4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3dc7, 3);  mov(al, memb[ds, eax + 94]);          /* mov al, [eax+0x5e] */
            ii(0x1015_3dca, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_3dcf, 3);  sar(eax, 6);                          /* sar eax, 0x6 */
            ii(0x1015_3dd2, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_3dd5, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_3ddc, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1015_3de3, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3de7, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x1015_3dea, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3dec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3def, 3);  mov(al, memb[ds, eax + 94]);          /* mov al, [eax+0x5e] */
            ii(0x1015_3df2, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_3df7, 3);  add(edx, 0x20);                       /* add edx, 0x20 */
            ii(0x1015_3dfa, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x1015_3dfc, 2);  if(jge(0x1015_3e27, 0x29)) goto l_0x1015_3e27;/* jge 0x10153e27 */
            ii(0x1015_3dfe, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3e01, 4);  test(memb[ds, eax + 94], 0x1f);       /* test byte [eax+0x5e], 0x1f */
            ii(0x1015_3e05, 2);  if(jnz(0x1015_3e25, 0x1e)) goto l_0x1015_3e25;/* jnz 0x10153e25 */
            ii(0x1015_3e07, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3e0b, 8);  movsx(ax, memb[ds, eax + 0x101b_d914]);/* movsx ax, byte [eax+0x101bd914] */
            ii(0x1015_3e13, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_3e16, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3e1a, 8);  movsx(ax, memb[ds, eax + 0x101b_d91c]);/* movsx ax, byte [eax+0x101bd91c] */
            ii(0x1015_3e22, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1015_3e25:
            ii(0x1015_3e25, 2);  jmp(0x1015_3e54, 0x2d); goto l_0x1015_3e54;/* jmp 0x10153e54 */
        l_0x1015_3e27:
            ii(0x1015_3e27, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3e2a, 4);  test(memb[ds, eax + 94], 0x1f);       /* test byte [eax+0x5e], 0x1f */
            ii(0x1015_3e2e, 2);  if(jnz(0x1015_3e54, 0x24)) goto l_0x1015_3e54;/* jnz 0x10153e54 */
            ii(0x1015_3e30, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3e34, 8);  movsx(ax, memb[ds, eax + 0x101b_d914]);/* movsx ax, byte [eax+0x101bd914] */
            ii(0x1015_3e3c, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_3e3f, 3);  neg(memd[ss, ebp - 20]);              /* neg dword [ebp-0x14] */
            ii(0x1015_3e42, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3e46, 8);  movsx(ax, memb[ds, eax + 0x101b_d91c]);/* movsx ax, byte [eax+0x101bd91c] */
            ii(0x1015_3e4e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_3e51, 3);  neg(memd[ss, ebp - 12]);              /* neg dword [ebp-0xc] */
        l_0x1015_3e54:
            ii(0x1015_3e54, 5);  cmp(memw[ss, ebp - 20], 0);           /* cmp word [ebp-0x14], 0x0 */
            ii(0x1015_3e59, 2);  if(jnz(0x1015_3e62, 7)) goto l_0x1015_3e62;/* jnz 0x10153e62 */
            ii(0x1015_3e5b, 5);  cmp(memw[ss, ebp - 12], 0);           /* cmp word [ebp-0xc], 0x0 */
            ii(0x1015_3e60, 2);  if(jz(0x1015_3ec5, 0x63)) goto l_0x1015_3ec5;/* jz 0x10153ec5 */
        l_0x1015_3e62:
            ii(0x1015_3e62, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3e65, 4);  cmp(memb[ds, eax + 95], 0);           /* cmp byte [eax+0x5f], 0x0 */
            ii(0x1015_3e69, 2);  if(jnz(0x1015_3e76, 0xb)) goto l_0x1015_3e76;/* jnz 0x10153e76 */
            ii(0x1015_3e6b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_3e6d, 5);  mov(al, memb[ds, 0x101c_947c]);       /* mov al, [0x101c947c] */
            ii(0x1015_3e72, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1015_3e74, 2);  if(jnz(0x1015_3e7c, 6)) goto l_0x1015_3e7c;/* jnz 0x10153e7c */
        l_0x1015_3e76:
            ii(0x1015_3e76, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_3e7a, 2);  jmp(0x1015_3ee9, 0x6d); goto l_0x1015_3ee9;/* jmp 0x10153ee9 */
        l_0x1015_3e7c:
            ii(0x1015_3e7c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3e7f, 5);  call(0x1014_9fa8, -0x9edc);           /* call 0x10149fa8 */
            ii(0x1015_3e84, 4);  movsx(ebx, memw[ss, ebp - 12]);       /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_3e88, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1015_3e8c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3e8f, 5);  call(0x1014_9c2f, -0xa265);           /* call 0x10149c2f */
            ii(0x1015_3e94, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_3e97, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3e9a, 7);  sub(memw[ds, edx + 217], ax);         /* sub [edx+0xd9], ax */
            ii(0x1015_3ea1, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_3ea4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3ea7, 7);  sub(memw[ds, edx + 219], ax);         /* sub [edx+0xdb], ax */
            ii(0x1015_3eae, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3eb1, 5);  call(0x1014_9cd1, -0xa1e5);           /* call 0x10149cd1 */
            ii(0x1015_3eb6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3eb9, 5);  call(0x1014_9fa8, -0x9f16);           /* call 0x10149fa8 */
            ii(0x1015_3ebe, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3ec1, 4);  mov(memb[ds, edx + 95], 1);           /* mov byte [edx+0x5f], 0x1 */
        l_0x1015_3ec5:
            ii(0x1015_3ec5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3ec8, 3);  inc(memb[ds, eax + 94]);              /* inc byte [eax+0x5e] */
            ii(0x1015_3ecb, 5);  cmp(memw[ss, ebp - 20], 0);           /* cmp word [ebp-0x14], 0x0 */
            ii(0x1015_3ed0, 2);  if(jnz(0x1015_3ed9, 7)) goto l_0x1015_3ed9;/* jnz 0x10153ed9 */
            ii(0x1015_3ed2, 5);  cmp(memw[ss, ebp - 12], 0);           /* cmp word [ebp-0xc], 0x0 */
            ii(0x1015_3ed7, 2);  if(jz(0x1015_3edf, 6)) goto l_0x1015_3edf;/* jz 0x10153edf */
        l_0x1015_3ed9:
            ii(0x1015_3ed9, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x1015_3edd, 2);  jmp(0x1015_3ee3, 4); goto l_0x1015_3ee3;/* jmp 0x10153ee3 */
        l_0x1015_3edf:
            ii(0x1015_3edf, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1015_3ee3:
            ii(0x1015_3ee3, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1015_3ee6, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
        l_0x1015_3ee9:
            ii(0x1015_3ee9, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1015_3eec, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_3eee, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_3eef, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_3ef0, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_3ef1, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_3ef2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_3ef3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_3ef4, 1);  ret();                                /* ret */
        }
    }
}

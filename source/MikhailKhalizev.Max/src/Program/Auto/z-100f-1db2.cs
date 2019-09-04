using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_1db2-41965f20")]
        public void Method_100f_1db2()
        {
            ii(0x100f_1db2, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x100f_1db7, 5);  call(Definitions.sys_check_available_stack_size, 0x7_3f96);/* call 0x10165d52 */
            ii(0x100f_1dbc, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_1dbd, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_1dbe, 1);  push(edx);                            /* push edx */
            ii(0x100f_1dbf, 1);  push(esi);                            /* push esi */
            ii(0x100f_1dc0, 1);  push(edi);                            /* push edi */
            ii(0x100f_1dc1, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_1dc2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_1dc4, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100f_1dca, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_1dcd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1dd0, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100f_1dd3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_1dd6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1dd9, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x100f_1ddd, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100f_1de0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_1de3, 3);  sub(eax, memd[ss, ebp - 8]);          /* sub eax, [ebp-0x8] */
            ii(0x100f_1de6, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_1de9, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_1ded, 3);  lea(eax, memd[ds, eax + eax * 2]);    /* lea eax, [eax+eax*2] */
            ii(0x100f_1df0, 6);  mov(edx, memd[ds, Definitions.ptr_to_pallete]);/* mov edx, [0x101c9464] */
            ii(0x100f_1df6, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100f_1df8, 3);  mov(memd[ss, ebp - 24], edx);         /* mov [ebp-0x18], edx */
            ii(0x100f_1dfb, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_1dff, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_1e01, 2);  if(jnz(0x100f_1e2f, 0x2c)) goto l_0x100f_1e2f;/* jnz 0x100f1e2f */
            ii(0x100f_1e03, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_1e05, 5);  mov(al, memb[ds, 0x101c_3898]);       /* mov al, [0x101c3898] */
            ii(0x100f_1e0a, 3);  cmp(eax, 7);                          /* cmp eax, 0x7 */
            ii(0x100f_1e0d, 2);  if(jle(0x100f_1e17, 8)) goto l_0x100f_1e17;/* jle 0x100f1e17 */
            ii(0x100f_1e0f, 6);  shr(memb[ds, 0x101c_3898], 1);        /* shr byte [0x101c3898], 1 */
            ii(0x100f_1e15, 2);  jmp(0x100f_1e1e, 7); goto l_0x100f_1e1e;/* jmp 0x100f1e1e */
        l_0x100f_1e17:
            ii(0x100f_1e17, 7);  mov(memb[ds, 0x101c_3898], 0x3f);     /* mov byte [0x101c3898], 0x3f */
        l_0x100f_1e1e:
            ii(0x100f_1e1e, 6);  mov(dl, memb[ds, 0x101c_3898]);       /* mov dl, [0x101c3898] */
            ii(0x100f_1e24, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_1e27, 3);  mov(memb[ds, eax + 1], dl);           /* mov [eax+0x1], dl */
            ii(0x100f_1e2a, 5);  jmp(0x100f_1efb, 0xcc); goto l_0x100f_1efb;/* jmp 0x100f1efb */
        l_0x100f_1e2f:
            ii(0x100f_1e2f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1e32, 3);  mov(al, memb[ds, eax + 4]);           /* mov al, [eax+0x4] */
            ii(0x100f_1e35, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100f_1e3a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_1e3c, 2);  if(jnz(0x100f_1e96, 0x58)) goto l_0x100f_1e96;/* jnz 0x100f1e96 */
            ii(0x100f_1e3e, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_1e41, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_1e44, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_1e47, 3);  add(eax, 3);                          /* add eax, 0x3 */
            ii(0x100f_1e4a, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100f_1e4d, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100f_1e52, 3);  mov(edx, memd[ss, ebp - 28]);         /* mov edx, [ebp-0x1c] */
            ii(0x100f_1e55, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100f_1e58, 5);  call(Definitions.sys_memcpy, 0x7_3fee);/* call 0x10165e4b */
            ii(0x100f_1e5d, 4);  movsx(ebx, memw[ss, ebp - 16]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x100f_1e61, 3);  lea(ebx, memd[ds, ebx + ebx * 2]);    /* lea ebx, [ebx+ebx*2] */
            ii(0x100f_1e64, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x100f_1e67, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_1e6a, 5);  call(Definitions.sys_memcpy, 0x7_3fdc);/* call 0x10165e4b */
            ii(0x100f_1e6f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1e72, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100f_1e74, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_1e77, 3);  lea(edx, memd[ds, eax + eax * 2]);    /* lea edx, [eax+eax*2] */
            ii(0x100f_1e7a, 5);  mov(eax, memd[ds, Definitions.ptr_to_pallete]);/* mov eax, [0x101c9464] */
            ii(0x100f_1e7f, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100f_1e81, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_1e84, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100f_1e89, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x100f_1e8c, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_1e8f, 5);  call(Definitions.sys_memcpy, 0x7_3fb7);/* call 0x10165e4b */
            ii(0x100f_1e94, 2);  jmp(0x100f_1efb, 0x65); goto l_0x100f_1efb;/* jmp 0x100f1efb */
        l_0x100f_1e96:
            ii(0x100f_1e96, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1e99, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100f_1e9b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_1e9e, 3);  lea(eax, memd[ds, eax + eax * 2]);    /* lea eax, [eax+eax*2] */
            ii(0x100f_1ea1, 6);  mov(edx, memd[ds, Definitions.ptr_to_pallete]);/* mov edx, [0x101c9464] */
            ii(0x100f_1ea7, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100f_1ea9, 3);  mov(memd[ss, ebp - 28], edx);         /* mov [ebp-0x1c], edx */
            ii(0x100f_1eac, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_1eaf, 3);  sub(eax, 3);                          /* sub eax, 0x3 */
            ii(0x100f_1eb2, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100f_1eb5, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100f_1eba, 3);  mov(edx, memd[ss, ebp - 28]);         /* mov edx, [ebp-0x1c] */
            ii(0x100f_1ebd, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100f_1ec0, 5);  call(Definitions.sys_memcpy, 0x7_3f86);/* call 0x10165e4b */
        l_0x100f_1ec5:
            ii(0x100f_1ec5, 3);  dec(memd[ss, ebp - 16]);              /* dec dword [ebp-0x10] */
            ii(0x100f_1ec8, 5);  cmp(memw[ss, ebp - 16], -1 /* 0xff */);/* cmp word [ebp-0x10], 0xffff */
            ii(0x100f_1ecd, 2);  if(jz(0x100f_1eeb, 0x1c)) goto l_0x100f_1eeb;/* jz 0x100f1eeb */
            ii(0x100f_1ecf, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100f_1ed4, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x100f_1ed7, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_1eda, 5);  call(Definitions.sys_memcpy, 0x7_3f6c);/* call 0x10165e4b */
            ii(0x100f_1edf, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100f_1ee2, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_1ee5, 4);  add(memd[ss, ebp - 32], -3 /* 0xfd */);/* add dword [ebp-0x20], 0xfffffffd */
            ii(0x100f_1ee9, 2);  jmp(0x100f_1ec5, -0x26); goto l_0x100f_1ec5;/* jmp 0x100f1ec5 */
        l_0x100f_1eeb:
            ii(0x100f_1eeb, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100f_1ef0, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x100f_1ef3, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_1ef6, 5);  call(Definitions.sys_memcpy, 0x7_3f50);/* call 0x10165e4b */
        l_0x100f_1efb:
            ii(0x100f_1efb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1efe, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_1f01, 2);  jmp(0x100f_1f09, 6); goto l_0x100f_1f09;/* jmp 0x100f1f09 */
        l_0x100f_1f03:
            ii(0x100f_1f03, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_1f06, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100f_1f09:
            ii(0x100f_1f09, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_1f0c, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x100f_1f10, 2);  if(jg(0x100f_1f38, 0x26)) goto l_0x100f_1f38;/* jg 0x100f1f38 */
            ii(0x100f_1f12, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_1f15, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x100f_1f17, 3);  mov(cl, memb[ds, eax + 2]);           /* mov cl, [eax+0x2] */
            ii(0x100f_1f1a, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_1f1d, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100f_1f1f, 3);  mov(bl, memb[ds, eax + 1]);           /* mov bl, [eax+0x1] */
            ii(0x100f_1f22, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_1f25, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_1f27, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x100f_1f29, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_1f2d, 5);  call(/* sys */ 0x1016_ccf8, 0x7_adc6);/* call 0x1016ccf8 */
            ii(0x100f_1f32, 4);  add(memd[ss, ebp - 24], 3);           /* add dword [ebp-0x18], 0x3 */
            ii(0x100f_1f36, 2);  jmp(0x100f_1f03, -0x35); goto l_0x100f_1f03;/* jmp 0x100f1f03 */
        l_0x100f_1f38:
            ii(0x100f_1f38, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_1f3a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_1f3b, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_1f3c, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_1f3d, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_1f3e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_1f3f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_1f40, 1);  ret();                                /* ret */
        }
    }
}

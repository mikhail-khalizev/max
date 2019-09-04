using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d292-68d98455")]
        public void Method_1011_d292()
        {
            ii(0x1011_d292, 5);  push(0x50);                           /* push 0x50 */
            ii(0x1011_d297, 5);  call(Definitions.sys_check_available_stack_size, 0x4_8ab6);/* call 0x10165d52 */
            ii(0x1011_d29c, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_d29d, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_d29e, 1);  push(esi);                            /* push esi */
            ii(0x1011_d29f, 1);  push(edi);                            /* push edi */
            ii(0x1011_d2a0, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_d2a1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_d2a3, 6);  sub(esp, 0x38);                       /* sub esp, 0x38 */
            ii(0x1011_d2a9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_d2ac, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_d2af, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d2b2, 3);  mov(ebx, memd[ds, eax + 65]);         /* mov ebx, [eax+0x41] */
            ii(0x1011_d2b5, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1011_d2b8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d2bb, 3);  mov(edx, memd[ds, eax + 63]);         /* mov edx, [eax+0x3f] */
            ii(0x1011_d2be, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_d2c1, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1011_d2c4, 5);  call(0x1007_6aac, -0xa_681d);         /* call 0x10076aac */
            ii(0x1011_d2c9, 3);  lea(edx, memd[ss, ebp - 52]);         /* lea edx, [ebp-0x34] */
            ii(0x1011_d2cc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_d2cf, 5);  call(0x100b_8204, -0x6_50d0);         /* call 0x100b8204 */
            ii(0x1011_d2d4, 5);  mov(eax, 0x1c);                       /* mov eax, 0x1c */
            ii(0x1011_d2d9, 5);  call(Definitions.sys_new, 0x4_8b22);  /* call 0x10165e00 */
            ii(0x1011_d2de, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_d2e1, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_d2e4, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_d2e7, 4);  cmp(memd[ss, ebp - 40], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1011_d2eb, 2);  if(jz(0x1011_d308, 0x1b)) goto l_0x1011_d308;/* jz 0x1011d308 */
            ii(0x1011_d2ed, 4);  movsx(ebx, memw[ss, ebp - 54]);       /* movsx ebx, word [ebp-0x36] */
            ii(0x1011_d2f1, 4);  movsx(edx, memw[ss, ebp - 56]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_d2f5, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_d2f8, 5);  call(Definitions.my_ctor_c20, -0x33a7);/* call 0x10119f56 */
            ii(0x1011_d2fd, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_d300, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_d303, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_d306, 2);  jmp(0x1011_d30e, 6); goto l_0x1011_d30e;/* jmp 0x1011d30e */
        l_0x1011_d308:
            ii(0x1011_d308, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1011_d30b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x1011_d30e:
            ii(0x1011_d30e, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1011_d311, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1011_d314, 5);  call(0x100a_b3b0, -0x7_1f69);         /* call 0x100ab3b0 */
            ii(0x1011_d319, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d31c, 5);  call(0x1007_623c, -0xa_70e5);         /* call 0x1007623c */
            ii(0x1011_d321, 4);  mov(ax, memw[ds, eax + 18]);          /* mov ax, [eax+0x12] */
            ii(0x1011_d325, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_d328, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1011_d32b, 3);  mov(ebx, memd[ds, ebx + 26]);         /* mov ebx, [ebx+0x1a] */
            ii(0x1011_d32e, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1011_d331, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d334, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1011_d337, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_d33a, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1011_d33d, 5);  call(0x1007_6aac, -0xa_6896);         /* call 0x10076aac */
            ii(0x1011_d342, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_d345, 4);  imul(eax, memd[ss, ebp - 12]);        /* imul eax, [ebp-0xc] */
            ii(0x1011_d349, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_d34c, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1011_d353, 2);  jmp(0x1011_d35b, 6); goto l_0x1011_d35b;/* jmp 0x1011d35b */
        l_0x1011_d355:
            ii(0x1011_d355, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d358, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1011_d35b:
            ii(0x1011_d35b, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1011_d35e, 5);  call(0x100b_82bc, -0x6_50a7);         /* call 0x100b82bc */
            ii(0x1011_d363, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1011_d367, 2);  if(jle(0x1011_d38e, 0x25)) goto l_0x1011_d38e;/* jle 0x1011d38e */
            ii(0x1011_d369, 3);  lea(edx, memd[ss, ebp - 56]);         /* lea edx, [ebp-0x38] */
            ii(0x1011_d36c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_d36f, 5);  call(0x1007_5e64, -0xa_7510);         /* call 0x10075e64 */
            ii(0x1011_d374, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1011_d376, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x1011_d379, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1011_d37c, 5);  call(0x1007_5e64, -0xa_751d);         /* call 0x10075e64 */
            ii(0x1011_d381, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1011_d383, 5);  call(0x1007_0c51, -0xa_c737);         /* call 0x10070c51 */
            ii(0x1011_d388, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x1011_d38c, 2);  if(jg(0x1011_d390, 2)) goto l_0x1011_d390;/* jg 0x1011d390 */
        l_0x1011_d38e:
            ii(0x1011_d38e, 2);  jmp(0x1011_d3f2, 0x62); goto l_0x1011_d3f2;/* jmp 0x1011d3f2 */
        l_0x1011_d390:
            ii(0x1011_d390, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_d394, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1011_d397, 5);  call(0x100b_827c, -0x6_5120);         /* call 0x100b827c */
            ii(0x1011_d39c, 4);  movsx(ax, memb[ds, eax]);             /* movsx ax, byte [eax] */
            ii(0x1011_d3a0, 4);  add(memw[ss, ebp - 32], ax);          /* add [ebp-0x20], ax */
            ii(0x1011_d3a4, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_d3a8, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1011_d3ab, 5);  call(0x100b_827c, -0x6_5134);         /* call 0x100b827c */
            ii(0x1011_d3b0, 5);  movsx(ax, memb[ds, eax + 1]);         /* movsx ax, byte [eax+0x1] */
            ii(0x1011_d3b5, 4);  add(memw[ss, ebp - 30], ax);          /* add [ebp-0x1e], ax */
            ii(0x1011_d3b9, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_d3bd, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1011_d3c0, 5);  call(0x100b_827c, -0x6_5149);         /* call 0x100b827c */
            ii(0x1011_d3c5, 5);  movsx(ax, memb[ds, eax + 1]);         /* movsx ax, byte [eax+0x1] */
            ii(0x1011_d3ca, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1011_d3cd, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_d3d1, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1011_d3d4, 5);  call(0x100b_827c, -0x6_515d);         /* call 0x100b827c */
            ii(0x1011_d3d9, 4);  movsx(ax, memb[ds, eax]);             /* movsx ax, byte [eax] */
            ii(0x1011_d3dd, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_d3e0, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1011_d3e3, 5);  call(0x100a_b2e0, -0x7_2108);         /* call 0x100ab2e0 */
            ii(0x1011_d3e8, 5);  call(0x1011_aca3, -0x274a);           /* call 0x1011aca3 */
            ii(0x1011_d3ed, 5);  jmp(0x1011_d355, -0x9d); goto l_0x1011_d355;/* jmp 0x1011d355 */
        l_0x1011_d3f2:
            ii(0x1011_d3f2, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1011_d3f6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_d3f8, 2);  if(jnz(0x1011_d409, 0xf)) goto l_0x1011_d409;/* jnz 0x1011d409 */
            ii(0x1011_d3fa, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_d3fc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d3ff, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x1011_d402, 5);  call(0x1007_6a34, -0xa_69d3);         /* call 0x10076a34 */
            ii(0x1011_d407, 2);  jmp(0x1011_d456, 0x4d); goto l_0x1011_d456;/* jmp 0x1011d456 */
        l_0x1011_d409:
            ii(0x1011_d409, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1011_d40c, 5);  call(0x100a_b33c, -0x7_20d5);         /* call 0x100ab33c */
            ii(0x1011_d411, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1011_d414, 3);  add(ebx, 0x65);                       /* add ebx, 0x65 */
            ii(0x1011_d417, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_d419, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1011_d41b, 5);  call(0x1007_6a34, -0xa_69ec);         /* call 0x10076a34 */
            ii(0x1011_d420, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d423, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1011_d427, 2);  if(jz(0x1011_d456, 0x2d)) goto l_0x1011_d456;/* jz 0x1011d456 */
            ii(0x1011_d429, 4);  movsx(ebx, memw[ss, ebp - 30]);       /* movsx ebx, word [ebp-0x1e] */
            ii(0x1011_d42d, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1011_d431, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d434, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x1011_d437, 5);  call(0x1007_69d8, -0xa_6a64);         /* call 0x100769d8 */
            ii(0x1011_d43c, 5);  call(0x1012_0bc0, 0x377f);            /* call 0x10120bc0 */
            ii(0x1011_d441, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d444, 5);  call(0x1011_9138, -0x4311);           /* call 0x10119138 */
            ii(0x1011_d449, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_d44b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d44e, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x1011_d451, 5);  call(0x1007_6a34, -0xa_6a22);         /* call 0x10076a34 */
        l_0x1011_d456:
            ii(0x1011_d456, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_d458, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1011_d45b, 5);  call(0x100a_9f38, -0x7_3528);         /* call 0x100a9f38 */
            ii(0x1011_d460, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_d462, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1011_d465, 5);  call(0x100b_7294, -0x6_61d6);         /* call 0x100b7294 */
            ii(0x1011_d46a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_d46c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_d46d, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_d46e, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_d46f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_d470, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_d471, 1);  ret();                                /* ret */
        }
    }
}

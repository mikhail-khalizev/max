using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b2e0-3390e5c3")]
        public void Method_1007_b2e0()
        {
            ii(0x1007_b2e0, 5);  push(0x60);                           /* push 0x60 */
            ii(0x1007_b2e5, 5);  call(Definitions.sys_check_available_stack_size, 0xe_aa68);/* call 0x10165d52 */
            ii(0x1007_b2ea, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_b2eb, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_b2ec, 1);  push(edx);                            /* push edx */
            ii(0x1007_b2ed, 1);  push(esi);                            /* push esi */
            ii(0x1007_b2ee, 1);  push(edi);                            /* push edi */
            ii(0x1007_b2ef, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_b2f0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_b2f2, 6);  sub(esp, 0x40);                       /* sub esp, 0x40 */
            ii(0x1007_b2f8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_b2fb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_b2fd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b300, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_b303, 5);  call(0x1013_ad11, 0xb_fa09);          /* call 0x1013ad11 */
            ii(0x1007_b308, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_b30a, 2);  if(jz(0x1007_b318, 0xc)) goto l_0x1007_b318;/* jz 0x1007b318 */
            ii(0x1007_b30c, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_b313, 5);  jmp(0x1007_b4a6, 0x18e); goto l_0x1007_b4a6;/* jmp 0x1007b4a6 */
        l_0x1007_b318:
            ii(0x1007_b318, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x1007_b31b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b31e, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_b321, 5);  call(0x1008_a228, 0xef02);            /* call 0x1008a228 */
            ii(0x1007_b326, 5);  call(0x100b_8e63, 0x3_db38);          /* call 0x100b8e63 */
            ii(0x1007_b32b, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_b32e, 5);  call(Definitions.my_ctor_0x101b_4184, -0x4843);/* call 0x10076af0 */
            ii(0x1007_b333, 6);  mov(ax, memw[ds, 0x101c_8172]);       /* mov ax, [0x101c8172] */
            ii(0x1007_b339, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_b33c, 5);  mov(eax, memd[ds, 0x101c_8172]);      /* mov eax, [0x101c8172] */
            ii(0x1007_b341, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_b344, 1);  push(eax);                            /* push eax */
            ii(0x1007_b345, 6);  mov(ecx, memd[ds, 0x101c_8170]);      /* mov ecx, [0x101c8170] */
            ii(0x1007_b34b, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1007_b34e, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_b350, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_b352, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_b355, 5);  call(0x1008_b148, 0xfdee);            /* call 0x1008b148 */
            ii(0x1007_b35a, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1007_b35c, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1007_b361, 5);  mov(edx, 0x3a);                       /* mov edx, 0x3a */
            ii(0x1007_b366, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b369, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1007_b36c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_b36f, 6);  imul(esi, eax, 0xc5);                 /* imul esi, eax, 0xc5 */
            ii(0x1007_b375, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x1007_b37a, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1007_b37c, 5);  call(0x100c_204f, 0x4_6cce);          /* call 0x100c204f */
            ii(0x1007_b381, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_b384, 4);  cmp(memd[ss, ebp - 40], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1007_b388, 2);  if(jnz(0x1007_b396, 0xc)) goto l_0x1007_b396;/* jnz 0x1007b396 */
            ii(0x1007_b38a, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_b391, 5);  jmp(0x1007_b4a6, 0x110); goto l_0x1007_b4a6;/* jmp 0x1007b4a6 */
        l_0x1007_b396:
            ii(0x1007_b396, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
            ii(0x1007_b39d, 2);  jmp(0x1007_b3a5, 6); goto l_0x1007_b3a5;/* jmp 0x1007b3a5 */
        l_0x1007_b39f:
            ii(0x1007_b39f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_b3a2, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x1007_b3a5:
            ii(0x1007_b3a5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_b3a8, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1007_b3ac, 6);  if(jge(0x1007_b4a0, 0xee)) goto l_0x1007_b4a0;/* jge 0x1007b4a0 */
            ii(0x1007_b3b2, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1007_b3b5, 3);  sub(eax, memd[ss, ebp - 8]);          /* sub eax, [ebp-0x8] */
            ii(0x1007_b3b8, 4);  mov(memw[ss, ebp - 36], ax);          /* mov [ebp-0x24], ax */
            ii(0x1007_b3bc, 3);  mov(eax, memd[ss, ebp - 30]);         /* mov eax, [ebp-0x1e] */
            ii(0x1007_b3bf, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1007_b3c2, 4);  mov(memw[ss, ebp - 34], ax);          /* mov [ebp-0x22], ax */
            ii(0x1007_b3c6, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1007_b3cd, 2);  jmp(0x1007_b3d3, 4); goto l_0x1007_b3d3;/* jmp 0x1007b3d3 */
        l_0x1007_b3cf:
            ii(0x1007_b3cf, 4);  add(memd[ss, ebp - 24], 2);           /* add dword [ebp-0x18], 0x2 */
        l_0x1007_b3d3:
            ii(0x1007_b3d3, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1007_b3d7, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1007_b3da, 6);  if(jge(0x1007_b49b, 0xbb)) goto l_0x1007_b49b;/* jge 0x1007b49b */
            ii(0x1007_b3e0, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_b3e7, 2);  jmp(0x1007_b3ef, 6); goto l_0x1007_b3ef;/* jmp 0x1007b3ef */
        l_0x1007_b3e9:
            ii(0x1007_b3e9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_b3ec, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1007_b3ef:
            ii(0x1007_b3ef, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_b3f3, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1007_b3f5, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1007_b3f9, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_b3fb, 6);  if(jge(0x1007_b496, 0x95)) goto l_0x1007_b496;/* jge 0x1007b496 */
            ii(0x1007_b401, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1007_b405, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1007_b408, 5);  mov(eax, 0x101c_5348);                /* mov eax, 0x101c5348 */
            ii(0x1007_b40d, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1007_b40f, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_b412, 5);  call(0x1008_b1a4, 0xfd8d);            /* call 0x1008b1a4 */
            ii(0x1007_b417, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1007_b41a, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_b41d, 5);  call(0x1010_82ce, 0x8_ceac);          /* call 0x101082ce */
            ii(0x1007_b422, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_b424, 2);  if(jz(0x1007_b441, 0x1b)) goto l_0x1007_b441;/* jz 0x1007b441 */
            ii(0x1007_b426, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1007_b42a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_b42d, 3);  add(eax, memd[ss, ebp - 40]);         /* add eax, [ebp-0x28] */
            ii(0x1007_b430, 4);  movsx(edx, memw[ss, ebp - 34]);       /* movsx edx, word [ebp-0x22] */
            ii(0x1007_b434, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1007_b436, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1007_b438, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_b43a, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1007_b43d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_b43f, 2);  if(jle(0x1007_b443, 2)) goto l_0x1007_b443;/* jle 0x1007b443 */
        l_0x1007_b441:
            ii(0x1007_b441, 2);  jmp(0x1007_b491, 0x4e); goto l_0x1007_b491;/* jmp 0x1007b491 */
        l_0x1007_b443:
            ii(0x1007_b443, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1007_b446, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_b449, 5);  call(0x1007_5e64, -0x55ea);           /* call 0x10075e64 */
            ii(0x1007_b44e, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1007_b450, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x1007_b453, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_b456, 5);  call(0x1007_5e64, -0x55f7);           /* call 0x10075e64 */
            ii(0x1007_b45b, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1007_b45d, 5);  call(0x100a_5fca, 0x2_ab68);          /* call 0x100a5fca */
            ii(0x1007_b462, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1007_b465, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1007_b467, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1007_b46a, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1007_b46c, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1007_b46e, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_b471, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_b474, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1007_b478, 2);  if(jge(0x1007_b491, 0x17)) goto l_0x1007_b491;/* jge 0x1007b491 */
            ii(0x1007_b47a, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_b47d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_b480, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_b483, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1007_b487, 2);  if(jl(0x1007_b491, 8)) goto l_0x1007_b491;/* jl 0x1007b491 */
            ii(0x1007_b489, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_b48c, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_b48f, 2);  jmp(0x1007_b4a6, 0x15); goto l_0x1007_b4a6;/* jmp 0x1007b4a6 */
        l_0x1007_b491:
            ii(0x1007_b491, 5);  jmp(0x1007_b3e9, -0xad); goto l_0x1007_b3e9;/* jmp 0x1007b3e9 */
        l_0x1007_b496:
            ii(0x1007_b496, 5);  jmp(0x1007_b3cf, -0xcc); goto l_0x1007_b3cf;/* jmp 0x1007b3cf */
        l_0x1007_b49b:
            ii(0x1007_b49b, 5);  jmp(0x1007_b39f, -0x101); goto l_0x1007_b39f;/* jmp 0x1007b39f */
        l_0x1007_b4a0:
            ii(0x1007_b4a0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_b4a3, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
        l_0x1007_b4a6:
            ii(0x1007_b4a6, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_b4a9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_b4ab, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_b4ac, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_b4ad, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_b4ae, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_b4af, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_b4b0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_b4b1, 1);  ret();                                /* ret */
        }
    }
}

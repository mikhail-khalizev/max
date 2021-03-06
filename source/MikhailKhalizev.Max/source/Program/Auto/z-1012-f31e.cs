using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_f31e-d64274b6")]
        public void Method_1012_f31e()
        {
            ii(0x1012_f31e, 5);  push(0x84);                           /* push 0x84 */
            ii(0x1012_f323, 5);  call(Definitions.sys_check_available_stack_size, 0x3_6a2a);/* call 0x10165d52 */
            ii(0x1012_f328, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_f329, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_f32a, 1);  push(edx);                            /* push edx */
            ii(0x1012_f32b, 1);  push(esi);                            /* push esi */
            ii(0x1012_f32c, 1);  push(edi);                            /* push edi */
            ii(0x1012_f32d, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_f32e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_f330, 6);  sub(esp, 0x50);                       /* sub esp, 0x50 */
            ii(0x1012_f336, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_f339, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_f33c, 6);  mov(eax, memd[ds, edx + 222]);        /* mov eax, [edx+0xde] */
            ii(0x1012_f342, 5);  call(0x100d_4f24, -0x5_a423);         /* call 0x100d4f24 */
            ii(0x1012_f347, 1);  cwde();                               /* cwde */
            ii(0x1012_f348, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_f34b, 3);  mov(ebx, memd[ds, edx + 58]);         /* mov ebx, [edx+0x3a] */
            ii(0x1012_f34e, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1012_f351, 3);  lea(edx, memd[ds, eax - 20]);         /* lea edx, [eax-0x14] */
            ii(0x1012_f354, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_f356, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_f359, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1012_f35b, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1012_f35e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_f361, 6);  mov(eax, memd[ds, edx + 222]);        /* mov eax, [edx+0xde] */
            ii(0x1012_f367, 5);  call(0x100d_4ef0, -0x5_a47c);         /* call 0x100d4ef0 */
            ii(0x1012_f36c, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_f36f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f372, 3);  add(eax, 0x22);                       /* add eax, 0x22 */
            ii(0x1012_f375, 5);  call(Definitions.my_2_get_count, -0xa_4012);/* call 0x1008b368 */
            ii(0x1012_f37a, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1012_f37d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f380, 3);  mov(ecx, memd[ds, eax + 58]);         /* mov ecx, [eax+0x3a] */
            ii(0x1012_f383, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1012_f386, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_f389, 3);  mov(eax, memd[ds, edx + 48]);         /* mov eax, [edx+0x30] */
            ii(0x1012_f38c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_f38f, 2);  add(eax, ecx);                        /* add eax, ecx */
            ii(0x1012_f391, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1012_f393, 5);  call(Definitions.my_min, -0xa_5c14);  /* call 0x10089784 */
            ii(0x1012_f398, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_f39b, 3);  lea(edx, memd[ss, ebp - 60]);         /* lea edx, [ebp-0x3c] */
            ii(0x1012_f39e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f3a1, 5);  call(0x100d_6a11, -0x5_8995);         /* call 0x100d6a11 */
            ii(0x1012_f3a6, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1012_f3ab, 5);  call(/* sys */ 0x1016_a24c, 0x3_ae9c);/* call 0x1016a24c */
            ii(0x1012_f3b0, 7);  add(memd[ss, ebp - 16], 0x91);        /* add dword [ebp-0x10], 0x91 */
            ii(0x1012_f3b7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_f3ba, 6);  mov(eax, memd[ds, edx + 222]);        /* mov eax, [edx+0xde] */
            ii(0x1012_f3c0, 5);  call(0x100d_4f58, -0x5_a46d);         /* call 0x100d4f58 */
            ii(0x1012_f3c5, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1012_f3c8, 6);  sub(edx, 0x91);                       /* sub edx, 0x91 */
            ii(0x1012_f3ce, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_f3d0, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_f3d3, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1012_f3d6, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x1012_f3d8, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x1012_f3db, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_f3de, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1012_f3e5, 2);  jmp(0x1012_f3ed, 6); goto l_0x1012_f3ed;/* jmp 0x1012f3ed */
        l_0x1012_f3e7:
            ii(0x1012_f3e7, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_f3ea, 3);  inc(memd[ss, ebp - 28]);              /* inc dword [ebp-0x1c] */
        l_0x1012_f3ed:
            ii(0x1012_f3ed, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_f3f1, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1012_f3f4, 6);  if(jge(0x1012_f477, 0x7d)) goto l_0x1012_f477;/* jge 0x1012f477 */
            ii(0x1012_f3fa, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_f3fe, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1012_f404, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_f40a, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_f40f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_f411, 2);  if(jz(0x1012_f472, 0x5f)) goto l_0x1012_f472;/* jz 0x1012f472 */
            ii(0x1012_f413, 5);  call(0x100d_531c, -0x5_a0fc);         /* call 0x100d531c */
            ii(0x1012_f418, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_f41d, 1);  push(eax);                            /* push eax */
            ii(0x1012_f41e, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1012_f423, 1);  push(eax);                            /* push eax */
            ii(0x1012_f424, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_f428, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1012_f42b, 6);  push(memd[ds, eax + 0x101b_b4a0]);    /* push dword [eax+0x101bb4a0] */
            ii(0x1012_f431, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x1012_f437, 1);  inc(eax);                             /* inc eax */
            ii(0x1012_f438, 1);  cwde();                               /* cwde */
            ii(0x1012_f439, 1);  push(eax);                            /* push eax */
            ii(0x1012_f43a, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_f43e, 1);  push(eax);                            /* push eax */
            ii(0x1012_f43f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f442, 6);  mov(eax, memd[ds, eax + 222]);        /* mov eax, [eax+0xde] */
            ii(0x1012_f448, 5);  call(0x100d_4ebc, -0x5_a591);         /* call 0x100d4ebc */
            ii(0x1012_f44d, 1);  cwde();                               /* cwde */
            ii(0x1012_f44e, 1);  push(eax);                            /* push eax */
            ii(0x1012_f44f, 4);  movsx(ecx, memw[ss, ebp - 16]);       /* movsx ecx, word [ebp-0x10] */
            ii(0x1012_f453, 4);  movsx(ebx, memw[ss, ebp - 28]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1012_f457, 3);  shl(ebx, 2);                          /* shl ebx, 0x2 */
            ii(0x1012_f45a, 6);  mov(ebx, memd[ds, ebx + 0x101b_b490]);/* mov ebx, [ebx+0x101bb490] */
            ii(0x1012_f460, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1012_f464, 3);  mov(eax, memd[ss, ebp - 38]);         /* mov eax, [ebp-0x26] */
            ii(0x1012_f467, 5);  call(0x100e_9ae5, -0x4_5987);         /* call 0x100e9ae5 */
            ii(0x1012_f46c, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_f46f, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
        l_0x1012_f472:
            ii(0x1012_f472, 5);  jmp(0x1012_f3e7, -0x90); goto l_0x1012_f3e7;/* jmp 0x1012f3e7 */
        l_0x1012_f477:
            ii(0x1012_f477, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_f47a, 6);  mov(eax, memd[ds, edx + 222]);        /* mov eax, [edx+0xde] */
            ii(0x1012_f480, 5);  call(0x100d_4ebc, -0x5_a5c9);         /* call 0x100d4ebc */
            ii(0x1012_f485, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1012_f488, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1012_f48c, 3);  sub(edx, 0x28);                       /* sub edx, 0x28 */
            ii(0x1012_f48f, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_f491, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_f494, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1012_f496, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1012_f498, 3);  add(ebx, 0x14);                       /* add ebx, 0x14 */
            ii(0x1012_f49b, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1012_f49d, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_f4a0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f4a3, 4);  mov(ax, memw[ds, eax + 50]);          /* mov ax, [eax+0x32] */
            ii(0x1012_f4a7, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_f4aa, 2);  jmp(0x1012_f4b2, 6); goto l_0x1012_f4b2;/* jmp 0x1012f4b2 */
        l_0x1012_f4ac:
            ii(0x1012_f4ac, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_f4af, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
        l_0x1012_f4b2:
            ii(0x1012_f4b2, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_f4b5, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1012_f4b9, 6);  if(jge(0x1012_f5de, 0x11f)) goto l_0x1012_f5de;/* jge 0x1012f5de */
            ii(0x1012_f4bf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f4c2, 6);  mov(eax, memd[ds, eax + 222]);        /* mov eax, [eax+0xde] */
            ii(0x1012_f4c8, 5);  call(0x100d_4ef0, -0x5_a5dd);         /* call 0x100d4ef0 */
            ii(0x1012_f4cd, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_f4d0, 5);  mov(eax, 0xa2);                       /* mov eax, 0xa2 */
            ii(0x1012_f4d5, 1);  push(eax);                            /* push eax */
            ii(0x1012_f4d6, 5);  mov(eax, 0x8c);                       /* mov eax, 0x8c */
            ii(0x1012_f4db, 1);  push(eax);                            /* push eax */
            ii(0x1012_f4dc, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f4e0, 1);  push(eax);                            /* push eax */
            ii(0x1012_f4e1, 4);  movsx(ecx, memw[ss, ebp - 16]);       /* movsx ecx, word [ebp-0x10] */
            ii(0x1012_f4e5, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1012_f4e9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f4ec, 3);  add(eax, 0x22);                       /* add eax, 0x22 */
            ii(0x1012_f4ef, 5);  call(0x1008_b228, -0xa_42cc);         /* call 0x1008b228 */
            ii(0x1012_f4f4, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x1012_f4f7, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1012_f4fb, 3);  mov(eax, memd[ss, ebp - 38]);         /* mov eax, [ebp-0x26] */
            ii(0x1012_f4fe, 5);  call(0x1012_b7dc, -0x3d27);           /* call 0x1012b7dc */
            ii(0x1012_f503, 7);  add(memd[ss, ebp - 16], 0x91);        /* add dword [ebp-0x10], 0x91 */
            ii(0x1012_f50a, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1012_f511, 2);  jmp(0x1012_f519, 6); goto l_0x1012_f519;/* jmp 0x1012f519 */
        l_0x1012_f513:
            ii(0x1012_f513, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_f516, 3);  inc(memd[ss, ebp - 28]);              /* inc dword [ebp-0x1c] */
        l_0x1012_f519:
            ii(0x1012_f519, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_f51d, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1012_f520, 6);  if(jge(0x1012_f5d3, 0xad)) goto l_0x1012_f5d3;/* jge 0x1012f5d3 */
            ii(0x1012_f526, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_f52a, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1012_f530, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_f536, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_f53b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_f53d, 6);  if(jz(0x1012_f5ce, 0x8b)) goto l_0x1012_f5ce;/* jz 0x1012f5ce */
            ii(0x1012_f543, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_f547, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1012_f54a, 6);  push(memd[ds, eax + 0x101b_b4a0]);    /* push dword [eax+0x101bb4a0] */
            ii(0x1012_f550, 4);  movsx(ecx, memw[ss, ebp - 44]);       /* movsx ecx, word [ebp-0x2c] */
            ii(0x1012_f554, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_f558, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_f55a, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_f55d, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1012_f55f, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1012_f561, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1012_f564, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1012_f567, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_f56b, 6);  imul(esi, eax, 0x247);                /* imul esi, eax, 0x247 */
            ii(0x1012_f571, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1012_f575, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f578, 3);  add(eax, 0x22);                       /* add eax, 0x22 */
            ii(0x1012_f57b, 5);  call(0x1008_b228, -0xa_4358);         /* call 0x1008b228 */
            ii(0x1012_f580, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1012_f583, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1012_f585, 2);  add(esi, eax);                        /* add esi, eax */
            ii(0x1012_f587, 6);  mov(esi, memd[ds, esi + 0x101c_a5e7]);/* mov esi, [esi+0x101ca5e7] */
            ii(0x1012_f58d, 3);  sar(esi, 0x10);                       /* sar esi, 0x10 */
            ii(0x1012_f590, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_f594, 3);  mov(edi, memd[ss, ebp - 38]);         /* mov edi, [ebp-0x26] */
            ii(0x1012_f597, 2);  add(edi, eax);                        /* add edi, eax */
            ii(0x1012_f599, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_f59d, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_f59f, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_f5a2, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1012_f5a4, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1012_f5a6, 2);  add(edi, eax);                        /* add edi, eax */
            ii(0x1012_f5a8, 3);  mov(memd[ss, ebp - 64], edi);         /* mov [ebp-0x40], edi */
            ii(0x1012_f5ab, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f5af, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1012_f5b3, 3);  add(eax, 0xb);                        /* add eax, 0xb */
            ii(0x1012_f5b6, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1012_f5b9, 3);  mov(edx, memd[ss, ebp - 64]);         /* mov edx, [ebp-0x40] */
            ii(0x1012_f5bc, 3);  add(edx, 0xf);                        /* add edx, 0xf */
            ii(0x1012_f5bf, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_f5c1, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1012_f5c3, 5);  call(0x1012_b658, -0x3f70);           /* call 0x1012b658 */
            ii(0x1012_f5c8, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_f5cb, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
        l_0x1012_f5ce:
            ii(0x1012_f5ce, 5);  jmp(0x1012_f513, -0xc0); goto l_0x1012_f513;/* jmp 0x1012f513 */
        l_0x1012_f5d3:
            ii(0x1012_f5d3, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1012_f5d6, 3);  add(memd[ss, ebp - 12], eax);         /* add [ebp-0xc], eax */
            ii(0x1012_f5d9, 5);  jmp(0x1012_f4ac, -0x132); goto l_0x1012_f4ac;/* jmp 0x1012f4ac */
        l_0x1012_f5de:
            ii(0x1012_f5de, 5);  call(0x100d_51e4, -0x5_a3ff);         /* call 0x100d51e4 */
            ii(0x1012_f5e3, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_f5e8, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1012_f5eb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f5ee, 3);  mov(eax, memd[ds, eax + 48]);         /* mov eax, [eax+0x30] */
            ii(0x1012_f5f1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_f5f4, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_f5f6, 2);  if(jle(0x1012_f5fe, 6)) goto l_0x1012_f5fe;/* jle 0x1012f5fe */
            ii(0x1012_f5f8, 4);  mov(memb[ss, ebp - 72], 1);           /* mov byte [ebp-0x48], 0x1 */
            ii(0x1012_f5fc, 2);  jmp(0x1012_f602, 4); goto l_0x1012_f602;/* jmp 0x1012f602 */
        l_0x1012_f5fe:
            ii(0x1012_f5fe, 4);  mov(memb[ss, ebp - 72], 0);           /* mov byte [ebp-0x48], 0x0 */
        l_0x1012_f602:
            ii(0x1012_f602, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_f604, 3);  mov(dl, memb[ss, ebp - 72]);          /* mov dl, [ebp-0x48] */
            ii(0x1012_f607, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f60a, 6);  mov(eax, memd[ds, eax + 206]);        /* mov eax, [eax+0xce] */
            ii(0x1012_f610, 3);  mov(ebx, memd[ss, ebp - 68]);         /* mov ebx, [ebp-0x44] */
            ii(0x1012_f613, 5);  call(0x100c_fa7c, -0x5_fb9c);         /* call 0x100cfa7c */
            ii(0x1012_f618, 5);  call(0x100d_51e4, -0x5_a439);         /* call 0x100d51e4 */
            ii(0x1012_f61d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_f622, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1012_f625, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f628, 3);  mov(edx, memd[ds, eax + 48]);         /* mov edx, [eax+0x30] */
            ii(0x1012_f62b, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_f62e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f631, 3);  mov(eax, memd[ds, eax + 58]);         /* mov eax, [eax+0x3a] */
            ii(0x1012_f634, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_f637, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1012_f639, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f63c, 3);  add(eax, 0x22);                       /* add eax, 0x22 */
            ii(0x1012_f63f, 5);  call(Definitions.my_2_get_count, -0xa_42dc);/* call 0x1008b368 */
            ii(0x1012_f644, 1);  cwde();                               /* cwde */
            ii(0x1012_f645, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1012_f647, 2);  if(jge(0x1012_f64f, 6)) goto l_0x1012_f64f;/* jge 0x1012f64f */
            ii(0x1012_f649, 4);  mov(memb[ss, ebp - 80], 1);           /* mov byte [ebp-0x50], 0x1 */
            ii(0x1012_f64d, 2);  jmp(0x1012_f653, 4); goto l_0x1012_f653;/* jmp 0x1012f653 */
        l_0x1012_f64f:
            ii(0x1012_f64f, 4);  mov(memb[ss, ebp - 80], 0);           /* mov byte [ebp-0x50], 0x0 */
        l_0x1012_f653:
            ii(0x1012_f653, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_f655, 3);  mov(dl, memb[ss, ebp - 80]);          /* mov dl, [ebp-0x50] */
            ii(0x1012_f658, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f65b, 6);  mov(eax, memd[ds, eax + 210]);        /* mov eax, [eax+0xd2] */
            ii(0x1012_f661, 3);  mov(ebx, memd[ss, ebp - 76]);         /* mov ebx, [ebp-0x4c] */
            ii(0x1012_f664, 5);  call(0x100c_fa7c, -0x5_fbed);         /* call 0x100cfa7c */
            ii(0x1012_f669, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_f66b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_f66c, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_f66d, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_f66e, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_f66f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_f670, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_f671, 1);  ret();                                /* ret */
        }
    }
}

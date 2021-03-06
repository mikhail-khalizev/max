using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_9fa6-e422bb07")]
        public void Method_1010_9fa6()
        {
            ii(0x1010_9fa6, 5);  push(0x64);                           /* push 0x64 */
            ii(0x1010_9fab, 5);  call(Definitions.sys_check_available_stack_size, 0x5_bda2);/* call 0x10165d52 */
            ii(0x1010_9fb0, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_9fb1, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_9fb2, 1);  push(esi);                            /* push esi */
            ii(0x1010_9fb3, 1);  push(edi);                            /* push edi */
            ii(0x1010_9fb4, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_9fb5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_9fb7, 6);  sub(esp, 0x3c);                       /* sub esp, 0x3c */
            ii(0x1010_9fbd, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_9fc0, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1010_9fc3, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_9fc7, 3);  imul(eax, eax, 0x18);                 /* imul eax, eax, 0x18 */
            ii(0x1010_9fca, 5);  mov(edx, 0x101b_a0e4);                /* mov edx, 0x101ba0e4 */
            ii(0x1010_9fcf, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_9fd1, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1010_9fd4, 4);  cmp(memb[ss, ebp - 4], 0x30);         /* cmp byte [ebp-0x4], 0x30 */
            ii(0x1010_9fd8, 2);  if(jl(0x1010_9fe6, 0xc)) goto l_0x1010_9fe6;/* jl 0x10109fe6 */
            ii(0x1010_9fda, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1010_9fdf, 5);  call(/* sys */ 0x1016_a24c, 0x6_0268);/* call 0x1016a24c */
            ii(0x1010_9fe4, 2);  jmp(0x1010_9ff0, 0xa); goto l_0x1010_9ff0;/* jmp 0x10109ff0 */
        l_0x1010_9fe6:
            ii(0x1010_9fe6, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1010_9feb, 5);  call(/* sys */ 0x1016_a24c, 0x6_025c);/* call 0x1016a24c */
        l_0x1010_9ff0:
            ii(0x1010_9ff0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_9ff3, 5);  cmp(memw[ds, eax + 8], -1 /* 0xff */);/* cmp word [eax+0x8], 0xffff */
            ii(0x1010_9ff8, 2);  if(jz(0x1010_a007, 0xd)) goto l_0x1010_a007;/* jz 0x1010a007 */
            ii(0x1010_9ffa, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_9ffd, 4);  cmp(memd[ds, eax + 10], 0);           /* cmp dword [eax+0xa], 0x0 */
            ii(0x1010_a001, 6);  if(jnz(0x1010_a0af, 0xa8)) goto l_0x1010_a0af;/* jnz 0x1010a0af */
        l_0x1010_a007:
            ii(0x1010_a007, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1010_a00c, 5);  call(Definitions.sys_new, 0x5_bdef);  /* call 0x10165e00 */
            ii(0x1010_a011, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_a014, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_a017, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_a01a, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_a01e, 2);  if(jz(0x1010_a061, 0x41)) goto l_0x1010_a061;/* jz 0x1010a061 */
            ii(0x1010_a020, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a023, 4);  mov(ax, memw[ds, eax + 6]);           /* mov ax, [eax+0x6] */
            ii(0x1010_a027, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_a02a, 4);  sub(ax, memw[ds, edx + 2]);           /* sub ax, [edx+0x2] */
            ii(0x1010_a02e, 1);  cwde();                               /* cwde */
            ii(0x1010_a02f, 1);  push(eax);                            /* push eax */
            ii(0x1010_a030, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a033, 4);  mov(ax, memw[ds, eax + 4]);           /* mov ax, [eax+0x4] */
            ii(0x1010_a037, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_a03a, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x1010_a03d, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1010_a040, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a043, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x1010_a045, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1010_a048, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a04b, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1010_a04e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_a051, 5);  call(0x100c_e39d, -0x3_bcb9);         /* call 0x100ce39d */
            ii(0x1010_a056, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_a059, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_a05c, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_a05f, 2);  jmp(0x1010_a067, 6); goto l_0x1010_a067;/* jmp 0x1010a067 */
        l_0x1010_a061:
            ii(0x1010_a061, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_a064, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
        l_0x1010_a067:
            ii(0x1010_a067, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x1010_a06b, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1010_a06e, 3);  add(edx, memd[ss, ebp - 8]);          /* add edx, [ebp-0x8] */
            ii(0x1010_a071, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_a074, 6);  mov(memd[ds, edx + 629], eax);        /* mov [edx+0x275], eax */
            ii(0x1010_a07a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a07d, 5);  cmp(memw[ds, eax + 8], -1 /* 0xff */);/* cmp word [eax+0x8], 0xffff */
            ii(0x1010_a082, 2);  if(jz(0x1010_a0aa, 0x26)) goto l_0x1010_a0aa;/* jz 0x1010a0aa */
            ii(0x1010_a084, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_a087, 2);  push(memd[ds, eax]);                  /* push dword [eax] */
            ii(0x1010_a089, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_a08e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a091, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x1010_a093, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1010_a096, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a099, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1010_a09c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a09f, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1010_a0a2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_a0a5, 5);  call(0x100e_8ef1, -0x2_11b9);         /* call 0x100e8ef1 */
        l_0x1010_a0aa:
            ii(0x1010_a0aa, 5);  jmp(0x1010_a16f, 0xc0); goto l_0x1010_a16f;/* jmp 0x1010a16f */
        l_0x1010_a0af:
            ii(0x1010_a0af, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1010_a0b4, 5);  call(Definitions.sys_new, 0x5_bd47);  /* call 0x10165e00 */
            ii(0x1010_a0b9, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_a0bc, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_a0bf, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_a0c2, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1010_a0c6, 2);  if(jz(0x1010_a0fe, 0x36)) goto l_0x1010_a0fe;/* jz 0x1010a0fe */
            ii(0x1010_a0c8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a0cb, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_a0cd, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_a0d0, 1);  push(eax);                            /* push eax */
            ii(0x1010_a0d1, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a0d4, 3);  movsx(ecx, memw[ds, eax]);            /* movsx ecx, word [eax] */
            ii(0x1010_a0d7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a0da, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1010_a0de, 1);  inc(eax);                             /* inc eax */
            ii(0x1010_a0df, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1010_a0e2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a0e5, 3);  mov(edx, memd[ds, eax + 6]);          /* mov edx, [eax+0x6] */
            ii(0x1010_a0e8, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_a0eb, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_a0ee, 5);  call(Definitions.my_ctor_c17, -0x3_bce4);/* call 0x100ce40f */
            ii(0x1010_a0f3, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1010_a0f6, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_a0f9, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1010_a0fc, 2);  jmp(0x1010_a104, 6); goto l_0x1010_a104;/* jmp 0x1010a104 */
        l_0x1010_a0fe:
            ii(0x1010_a0fe, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_a101, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
        l_0x1010_a104:
            ii(0x1010_a104, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x1010_a108, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1010_a10b, 3);  add(edx, memd[ss, ebp - 8]);          /* add edx, [ebp-0x8] */
            ii(0x1010_a10e, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1010_a111, 6);  mov(memd[ds, edx + 629], eax);        /* mov [edx+0x275], eax */
            ii(0x1010_a117, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a11a, 4);  cmp(memd[ds, eax + 10], 0);           /* cmp dword [eax+0xa], 0x0 */
            ii(0x1010_a11e, 2);  if(jz(0x1010_a16f, 0x4f)) goto l_0x1010_a16f;/* jz 0x1010a16f */
            ii(0x1010_a120, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1010_a123, 5);  call(0x100d_5224, -0x3_4f04);         /* call 0x100d5224 */
            ii(0x1010_a128, 1);  push(eax);                            /* push eax */
            ii(0x1010_a129, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1010_a12c, 5);  call(0x100d_5250, -0x3_4ee1);         /* call 0x100d5250 */
            ii(0x1010_a131, 1);  push(eax);                            /* push eax */
            ii(0x1010_a132, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1010_a135, 5);  call(0x100d_527c, -0x3_4ebe);         /* call 0x100d527c */
            ii(0x1010_a13a, 1);  push(eax);                            /* push eax */
            ii(0x1010_a13b, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x1010_a13e, 5);  call(0x100d_52a8, -0x3_4e9b);         /* call 0x100d52a8 */
            ii(0x1010_a143, 1);  push(eax);                            /* push eax */
            ii(0x1010_a144, 5);  call(0x100d_52d4, -0x3_4e75);         /* call 0x100d52d4 */
            ii(0x1010_a149, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1010_a14c, 5);  call(0x100d_52f8, -0x3_4e59);         /* call 0x100d52f8 */
            ii(0x1010_a151, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1010_a154, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a157, 3);  mov(edx, memd[ds, eax + 10]);         /* mov edx, [eax+0xa] */
            ii(0x1010_a15a, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a15e, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_a161, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a164, 6);  mov(eax, memd[ds, eax + 629]);        /* mov eax, [eax+0x275] */
            ii(0x1010_a16a, 5);  call(0x100c_ef64, -0x3_b20b);         /* call 0x100cef64 */
        l_0x1010_a16f:
            ii(0x1010_a16f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_a171, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a175, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_a178, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a17b, 6);  mov(eax, memd[ds, eax + 629]);        /* mov eax, [eax+0x275] */
            ii(0x1010_a181, 5);  call(0x100d_5194, -0x3_4ff2);         /* call 0x100d5194 */
            ii(0x1010_a186, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a18a, 6);  lea(edx, memd[ds, eax + 1000]);       /* lea edx, [eax+0x3e8] */
            ii(0x1010_a190, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a194, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_a197, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a19a, 6);  mov(eax, memd[ds, eax + 629]);        /* mov eax, [eax+0x275] */
            ii(0x1010_a1a0, 5);  call(0x100d_5134, -0x3_5071);         /* call 0x100d5134 */
            ii(0x1010_a1a5, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x1010_a1a9, 6);  add(edx, 0x7000);                     /* add edx, 0x7000 */
            ii(0x1010_a1af, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a1b3, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_a1b6, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a1b9, 6);  mov(eax, memd[ds, eax + 629]);        /* mov eax, [eax+0x275] */
            ii(0x1010_a1bf, 5);  call(0x100d_5164, -0x3_5060);         /* call 0x100d5164 */
            ii(0x1010_a1c4, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_a1c7, 3);  mov(edx, memd[ds, edx + 20]);         /* mov edx, [edx+0x14] */
            ii(0x1010_a1ca, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_a1cd, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a1d1, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_a1d4, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a1d7, 6);  mov(eax, memd[ds, eax + 629]);        /* mov eax, [eax+0x275] */
            ii(0x1010_a1dd, 5);  call(0x100d_50d4, -0x3_510e);         /* call 0x100d50d4 */
            ii(0x1010_a1e2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_a1e5, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_a1e7, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x1010_a1ea, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a1ee, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_a1f1, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a1f4, 6);  mov(eax, memd[ds, eax + 629]);        /* mov eax, [eax+0x275] */
            ii(0x1010_a1fa, 5);  call(0x100c_f85c, -0x3_a9a3);         /* call 0x100cf85c */
            ii(0x1010_a1ff, 5);  call(0x100d_51e4, -0x3_5020);         /* call 0x100d51e4 */
            ii(0x1010_a204, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1010_a206, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1010_a208, 5);  call(0x100d_5204, -0x3_5009);         /* call 0x100d5204 */
            ii(0x1010_a20d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_a20f, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1010_a211, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a215, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_a218, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a21b, 6);  mov(eax, memd[ds, eax + 629]);        /* mov eax, [eax+0x275] */
            ii(0x1010_a221, 5);  call(0x100c_fa7c, -0x3_a7aa);         /* call 0x100cfa7c */
            ii(0x1010_a226, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x1010_a22a, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a22e, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1010_a231, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a234, 6);  add(edx, 0x3e8);                      /* add edx, 0x3e8 */
            ii(0x1010_a23a, 3);  mov(memd[ds, eax + 17], edx);         /* mov [eax+0x11], edx */
            ii(0x1010_a23d, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a241, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1010_a244, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a247, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_a24a, 3);  mov(edx, memd[ds, edx + 14]);         /* mov edx, [edx+0xe] */
            ii(0x1010_a24d, 3);  mov(memd[ds, eax + 21], edx);         /* mov [eax+0x15], edx */
            ii(0x1010_a250, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_a254, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1010_a257, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a25a, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_a25d, 3);  mov(edx, memd[ds, edx + 18]);         /* mov edx, [edx+0x12] */
            ii(0x1010_a260, 3);  mov(memd[ds, eax + 25], edx);         /* mov [eax+0x19], edx */
            ii(0x1010_a263, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_a265, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_a266, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_a267, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_a268, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_a269, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_a26a, 1);  ret();                                /* ret */
        }
    }
}

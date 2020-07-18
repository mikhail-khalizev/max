using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_fe4d-6bad1cc7")]
        public void Method_100c_fe4d()
        {
            ii(0x100c_fe4d, 5);  push(0x5c);                           /* push 0x5c */
            ii(0x100c_fe52, 5);  call(Definitions.sys_check_available_stack_size, 0x9_5efb);/* call 0x10165d52 */
            ii(0x100c_fe57, 1);  push(esi);                            /* push esi */
            ii(0x100c_fe58, 1);  push(edi);                            /* push edi */
            ii(0x100c_fe59, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_fe5a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_fe5c, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x100c_fe62, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_fe65, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100c_fe68, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100c_fe6b, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100c_fe6e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_fe71, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_fe74, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
            ii(0x100c_fe76, 5);  call(0x1009_cb74, -0x3_3307);         /* call 0x1009cb74 */
            ii(0x100c_fe7b, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_fe7d, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100c_fe7f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_fe82, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_fe85, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100c_fe88, 5);  call(0x1009_cab0, -0x3_33dd);         /* call 0x1009cab0 */
            ii(0x100c_fe8d, 3);  sub(eax, 0x1e);                       /* sub eax, 0x1e */
            ii(0x100c_fe90, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_fe93, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_fe96, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_fe99, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100c_fe9c, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_fe9f, 4);  mov(memw[ds, edx + 46], ax);          /* mov [edx+0x2e], ax */
            ii(0x100c_fea3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_fea6, 3);  add(eax, 0x30);                       /* add eax, 0x30 */
            ii(0x100c_fea9, 5);  call(0x100e_9408, 0x1_955a);          /* call 0x100e9408 */
            ii(0x100c_feae, 3);  sub(eax, 0x30);                       /* sub eax, 0x30 */
            ii(0x100c_feb1, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_feb4, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_feb7, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100c_feba, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x100c_febd, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_fec0, 3);  mov(memd[ds, edx + 56], eax);         /* mov [edx+0x38], eax */
            ii(0x100c_fec3, 3);  mov(eax, memd[ss, ebp + 28]);         /* mov eax, [ebp+0x1c] */
            ii(0x100c_fec6, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_fec9, 3);  mov(memd[ds, edx + 60], eax);         /* mov [edx+0x3c], eax */
            ii(0x100c_fecc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_fecf, 7);  mov(memd[ds, eax + 64], 0x101b_5cbc); /* mov dword [eax+0x40], 0x101b5cbc */
            ii(0x100c_fed6, 5);  mov(ecx, 6);                          /* mov ecx, 0x6 */
            ii(0x100c_fedb, 3);  mov(edi, memd[ss, ebp - 16]);         /* mov edi, [ebp-0x10] */
            ii(0x100c_fede, 3);  lea(edi, memd[ds, edi + 4]);          /* lea edi, [edi+0x4] */
            ii(0x100c_fee1, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x100c_fee4, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x100c_fee6, 2);  movsw();                              /* movsw */
            ii(0x100c_fee8, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100c_feeb, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_feee, 4);  mov(memw[ds, edx + 34], ax);          /* mov [edx+0x22], ax */
            ii(0x100c_fef2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_fef5, 6);  mov(memw[ds, eax + 36], 0);           /* mov word [eax+0x24], 0x0 */
            ii(0x100c_fefb, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_fefe, 6);  mov(memw[ds, eax + 38], 0);           /* mov word [eax+0x26], 0x0 */
            ii(0x100c_ff04, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_ff07, 3);  mov(edx, memd[ds, edx + 44]);         /* mov edx, [edx+0x2c] */
            ii(0x100c_ff0a, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100c_ff0d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ff10, 3);  mov(eax, memd[ds, eax + 56]);         /* mov eax, [eax+0x38] */
            ii(0x100c_ff13, 5);  call(0x100d_5134, 0x521c);            /* call 0x100d5134 */
            ii(0x100c_ff18, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_ff1b, 3);  mov(edx, memd[ds, edx + 44]);         /* mov edx, [edx+0x2c] */
            ii(0x100c_ff1e, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100c_ff21, 1);  inc(edx);                             /* inc edx */
            ii(0x100c_ff22, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ff25, 3);  mov(eax, memd[ds, eax + 60]);         /* mov eax, [eax+0x3c] */
            ii(0x100c_ff28, 5);  call(0x100d_5134, 0x5207);            /* call 0x100d5134 */
            ii(0x100c_ff2d, 5);  mov(edx, 0x7000);                     /* mov edx, 0x7000 */
            ii(0x100c_ff32, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ff35, 3);  mov(eax, memd[ds, eax + 56]);         /* mov eax, [eax+0x38] */
            ii(0x100c_ff38, 5);  call(0x100d_5164, 0x5227);            /* call 0x100d5164 */
            ii(0x100c_ff3d, 5);  mov(edx, 0x7001);                     /* mov edx, 0x7001 */
            ii(0x100c_ff42, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ff45, 3);  mov(eax, memd[ds, eax + 60]);         /* mov eax, [eax+0x3c] */
            ii(0x100c_ff48, 5);  call(0x100d_5164, 0x5217);            /* call 0x100d5164 */
            ii(0x100c_ff4d, 5);  mov(edx, 0x4ff);                      /* mov edx, 0x4ff */
            ii(0x100c_ff52, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ff55, 3);  mov(eax, memd[ds, eax + 56]);         /* mov eax, [eax+0x38] */
            ii(0x100c_ff58, 5);  call(0x100d_50d4, 0x5177);            /* call 0x100d50d4 */
            ii(0x100c_ff5d, 5);  mov(edx, 0x4ff);                      /* mov edx, 0x4ff */
            ii(0x100c_ff62, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ff65, 3);  mov(eax, memd[ds, eax + 60]);         /* mov eax, [eax+0x3c] */
            ii(0x100c_ff68, 5);  call(0x100d_50d4, 0x5167);            /* call 0x100d50d4 */
            ii(0x100c_ff6d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_ff70, 3);  mov(edx, memd[ds, edx + 12]);         /* mov edx, [edx+0xc] */
            ii(0x100c_ff73, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ff76, 3);  sub(edx, memd[ds, eax + 4]);          /* sub edx, [eax+0x4] */
            ii(0x100c_ff79, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_ff7b, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_ff7e, 3);  shl(edx, 5);                          /* shl edx, 0x5 */
            ii(0x100c_ff81, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x100c_ff83, 3);  sar(eax, 5);                          /* sar eax, 0x5 */
            ii(0x100c_ff86, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_ff89, 4);  mov(memw[ds, edx + 40], ax);          /* mov [edx+0x28], ax */
            ii(0x100c_ff8d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_ff90, 3);  mov(edx, memd[ds, edx + 18]);         /* mov edx, [edx+0x12] */
            ii(0x100c_ff93, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ff96, 3);  mov(eax, memd[ds, eax + 56]);         /* mov eax, [eax+0x38] */
            ii(0x100c_ff99, 5);  call(0x100c_f85c, -0x742);            /* call 0x100cf85c */
            ii(0x100c_ff9e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ffa1, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x100c_ffa4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ffa7, 3);  mov(eax, memd[ds, eax + 60]);         /* mov eax, [eax+0x3c] */
            ii(0x100c_ffaa, 5);  call(0x100c_f85c, -0x753);            /* call 0x100cf85c */
            ii(0x100c_ffaf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ffb2, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100c_ffb6, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_ffb9, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x100c_ffbc, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_ffbf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ffc2, 4);  mov(ax, memw[ds, eax + 40]);          /* mov ax, [eax+0x28] */
            ii(0x100c_ffc6, 3);  shl(eax, 5);                          /* shl eax, 0x5 */
            ii(0x100c_ffc9, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_ffcc, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100c_ffd3, 2);  jmp(0x100c_ffdb, 6); goto l_0x100c_ffdb;/* jmp 0x100cffdb */
        l_0x100c_ffd5:
            ii(0x100c_ffd5, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_ffd8, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x100c_ffdb:
            ii(0x100c_ffdb, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_ffde, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_ffe1, 4);  cmp(ax, memw[ds, edx + 40]);          /* cmp ax, [edx+0x28] */
            ii(0x100c_ffe5, 2);  if(jge(0x100d_003c, 0x55)) goto l_0x100d_003c;/* jge 0x100d003c */
            ii(0x100c_ffe7, 2);  push(0);                              /* push 0x0 */
            ii(0x100c_ffe9, 2);  push(0);                              /* push 0x0 */
            ii(0x100c_ffeb, 2);  push(0);                              /* push 0x0 */
            ii(0x100c_ffed, 2);  push(0);                              /* push 0x0 */
            ii(0x100c_ffef, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_fff2, 3);  mov(eax, memd[ds, eax + 44]);         /* mov eax, [eax+0x2c] */
            ii(0x100c_fff5, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_fff8, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100c_fffc, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x100c_ffff, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_0001, 1);  push(eax);                            /* push eax */
            ii(0x100d_0002, 2);  push(-1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x100d_0004, 2);  push(-1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x100d_0006, 2);  push(-1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x100d_0008, 2);  push(0x20);                           /* push 0x20 */
            ii(0x100d_000a, 4);  movsx(ecx, memw[ss, ebp - 28]);       /* movsx ecx, word [ebp-0x1c] */
            ii(0x100d_000e, 4);  movsx(ebx, memw[ss, ebp - 20]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x100d_0012, 3);  shl(ebx, 5);                          /* shl ebx, 0x5 */
            ii(0x100d_0015, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0018, 3);  add(ebx, memd[ds, eax + 4]);          /* add ebx, [eax+0x4] */
            ii(0x100d_001b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_001e, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100d_0020, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0023, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100d_0026, 5);  call(/* sys */ 0x1016_86b0, 0x9_8685);/* call 0x101686b0 */
            ii(0x100d_002b, 3);  mov(ebx, memd[ss, ebp - 16]);         /* mov ebx, [ebp-0x10] */
            ii(0x100d_002e, 3);  add(ebx, 0x30);                       /* add ebx, 0x30 */
            ii(0x100d_0031, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_0033, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100d_0035, 5);  call(0x100e_9450, 0x1_9416);          /* call 0x100e9450 */
            ii(0x100d_003a, 2);  jmp(0x100c_ffd5, -0x67); goto l_0x100c_ffd5;/* jmp 0x100cffd5 */
        l_0x100d_003c:
            ii(0x100d_003c, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100d_0040, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100d_0044, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x100d_0047, 3);  add(eax, 8);                          /* add eax, 0x8 */
            ii(0x100d_004a, 5);  call(Definitions.sys_malloc, 0x9_af8f);/* call 0x1016afde */
            ii(0x100d_004f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_0051, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_0054, 3);  mov(memd[ds, eax + 42], edx);         /* mov [eax+0x2a], edx */
            ii(0x100d_0057, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_005a, 3);  mov(edx, memd[ds, eax + 42]);         /* mov edx, [eax+0x2a] */
            ii(0x100d_005d, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_0060, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x100d_0063, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_0066, 3);  mov(edx, memd[ds, eax + 42]);         /* mov edx, [eax+0x2a] */
            ii(0x100d_0069, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_006c, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
            ii(0x100d_0070, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_0074, 1);  push(eax);                            /* push eax */
            ii(0x100d_0075, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_0078, 3);  mov(eax, memd[ds, eax + 42]);         /* mov eax, [eax+0x2a] */
            ii(0x100d_007b, 3);  add(eax, 8);                          /* add eax, 0x8 */
            ii(0x100d_007e, 1);  push(eax);                            /* push eax */
            ii(0x100d_007f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0082, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100d_0085, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_0088, 1);  push(eax);                            /* push eax */
            ii(0x100d_0089, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100d_008d, 1);  push(eax);                            /* push eax */
            ii(0x100d_008e, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_0092, 1);  push(eax);                            /* push eax */
            ii(0x100d_0093, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0096, 3);  push(memd[ds, eax + 22]);             /* push dword [eax+0x16] */
            ii(0x100d_0099, 5);  call(/* sys */ 0x1016_abbc, 0x9_ab1e);/* call 0x1016abbc */
            ii(0x100d_009e, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x100d_00a1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_00a4, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_00a7, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_00aa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_00ac, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_00ad, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_00ae, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_00af, 3);  ret(0x10);                            /* ret 0x10 */
        }
    }
}

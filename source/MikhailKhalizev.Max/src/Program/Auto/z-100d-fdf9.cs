using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_fdf9-38853b4e")]
        public void Method_100d_fdf9()
        {
            ii(0x100d_fdf9, 5);  push(0x4c);                           /* push 0x4c */
            ii(0x100d_fdfe, 5);  call(Definitions.sys_check_available_stack_size, 0x8_5f4f);/* call 0x10165d52 */
            ii(0x100d_fe03, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_fe04, 1);  push(esi);                            /* push esi */
            ii(0x100d_fe05, 1);  push(edi);                            /* push edi */
            ii(0x100d_fe06, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_fe07, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_fe09, 6);  sub(esp, 0x38);                       /* sub esp, 0x38 */
            ii(0x100d_fe0f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_fe12, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100d_fe15, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100d_fe18, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_fe1c, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100d_fe20, 6);  imul(edx, edx, 0x247);                /* imul edx, edx, 0x247 */
            ii(0x100d_fe26, 6);  mov(ebx, memd[ds, edx + 0x101c_a562]);/* mov ebx, [edx+0x101ca562] */
            ii(0x100d_fe2c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_fe2e, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100d_fe30, 5);  call(0x100c_b6b0, -0x1_4785);         /* call 0x100cb6b0 */
            ii(0x100d_fe35, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x100d_fe38, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_fe3a, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100d_fe3c, 5);  call(0x1007_6800, -0x6_9641);         /* call 0x10076800 */
            ii(0x100d_fe41, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100d_fe45, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fe49, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100d_fe4f, 6);  mov(eax, memd[ds, eax + 0x101c_a562]);/* mov eax, [eax+0x101ca562] */
            ii(0x100d_fe55, 5);  call(0x1008_b104, -0x5_4d56);         /* call 0x1008b104 */
            ii(0x100d_fe5a, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_fe5c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100d_fe5f, 5);  call(0x1007_6800, -0x6_9664);         /* call 0x10076800 */
            ii(0x100d_fe64, 4);  movsx(ebx, memb[ss, ebp - 4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x100d_fe68, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100d_fe6c, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fe70, 5);  call(0x100d_fd69, -0x10c);            /* call 0x100dfd69 */
            ii(0x100d_fe75, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_fe78, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_fe7b, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x100d_fe7e, 5);  jmp(0x100d_ff58, 0xd5); goto l_0x100d_ff58;/* jmp 0x100dff58 */
        l_0x100d_fe83:
            ii(0x100d_fe83, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_fe87, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_fe89, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fe8d, 5);  call(0x1013_3743, 0x5_38b1);          /* call 0x10133743 */
            ii(0x100d_fe92, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_fe95, 5);  jmp(0x100d_ff75, 0xdb); goto l_0x100d_ff75;/* jmp 0x100dff75 */
        l_0x100d_fe9a:
            ii(0x100d_fe9a, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_fe9e, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_fea3, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fea7, 5);  call(0x1013_3743, 0x5_3897);          /* call 0x10133743 */
            ii(0x100d_feac, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_feaf, 5);  jmp(0x100d_ff75, 0xc1); goto l_0x100d_ff75;/* jmp 0x100dff75 */
        l_0x100d_feb4:
            ii(0x100d_feb4, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_feb8, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x100d_febd, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fec1, 5);  call(0x1013_3743, 0x5_387d);          /* call 0x10133743 */
            ii(0x100d_fec6, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_fec9, 5);  jmp(0x100d_ff75, 0xa7); goto l_0x100d_ff75;/* jmp 0x100dff75 */
        l_0x100d_fece:
            ii(0x100d_fece, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_fed2, 5);  mov(edx, 3);                          /* mov edx, 0x3 */
            ii(0x100d_fed7, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fedb, 5);  call(0x1013_3743, 0x5_3863);          /* call 0x10133743 */
            ii(0x100d_fee0, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_fee3, 5);  jmp(0x100d_ff75, 0x8d); goto l_0x100d_ff75;/* jmp 0x100dff75 */
        l_0x100d_fee8:
            ii(0x100d_fee8, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_feec, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x100d_fef1, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fef5, 5);  call(0x1013_3743, 0x5_3849);          /* call 0x10133743 */
            ii(0x100d_fefa, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_fefd, 5);  jmp(0x100d_ff75, 0x73); goto l_0x100d_ff75;/* jmp 0x100dff75 */
        l_0x100d_ff02:
            ii(0x100d_ff02, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_ff06, 5);  mov(edx, 6);                          /* mov edx, 0x6 */
            ii(0x100d_ff0b, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_ff0f, 5);  call(0x1013_3743, 0x5_382f);          /* call 0x10133743 */
            ii(0x100d_ff14, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_ff17, 2);  jmp(0x100d_ff75, 0x5c); goto l_0x100d_ff75;/* jmp 0x100dff75 */
        l_0x100d_ff19:
            ii(0x100d_ff19, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_ff1d, 5);  mov(edx, 5);                          /* mov edx, 0x5 */
            ii(0x100d_ff22, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_ff26, 5);  call(0x1013_3743, 0x5_3818);          /* call 0x10133743 */
            ii(0x100d_ff2b, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x100d_ff2e:
            ii(0x100d_ff2e, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100d_ff35, 2);  jmp(0x100d_ff75, 0x3e); goto l_0x100d_ff75;/* jmp 0x100dff75 */
        //  ii(0x100d_ff37, 1);  nop();                                /* nop */
        //  ii(0x100d_ff38, 32);  /* Служебная область с абсолютными адресами переходов. (0x100d_fe83, 0x100d_fe9a, 0x100d_feb4, 0x100d_ff2e, 0x100d_fece, 0x100d_fee8, 0x100d_ff02, 0x100d_ff19). */
        l_0x100d_ff58:
            ii(0x100d_ff58, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100d_ff5b, 2);  dec(al);                              /* dec al */
            ii(0x100d_ff5d, 3);  mov(memb[ss, ebp - 36], al);          /* mov [ebp-0x24], al */
            ii(0x100d_ff60, 4);  cmp(memb[ss, ebp - 36], 7);           /* cmp byte [ebp-0x24], 0x7 */
            ii(0x100d_ff64, 2);  if(ja(0x100d_ff2e, -0x38)) goto l_0x100d_ff2e;/* ja 0x100dff2e */
            ii(0x100d_ff66, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_ff68, 3);  mov(al, memb[ss, ebp - 36]);          /* mov al, [ebp-0x24] */
            ii(0x100d_ff6b, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_ff6e, 7);  
            switch (jmp_abs_switch(memd[cs, eax + 0x100d_ff38]))
            {
                case 0x100d_fe83:
                    goto l_0x100d_fe83;
                case 0x100d_fe9a:
                    goto l_0x100d_fe9a;
                case 0x100d_feb4:
                    goto l_0x100d_feb4;
                case 0x100d_fece:
                    goto l_0x100d_fece;
                case 0x100d_fee8:
                    goto l_0x100d_fee8;
                case 0x100d_ff02:
                    goto l_0x100d_ff02;
                case 0x100d_ff19:
                    goto l_0x100d_ff19;
                case 0x100d_ff2e:
                    goto l_0x100d_ff2e;
                default:
                    throw new NotImplementedException();
            }/* jmp dword [cs:eax+0x100dff38] */
        l_0x100d_ff75:
            ii(0x100d_ff75, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x100d_ff79, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_ff7c, 5);  call(0x1007_6730, -0x6_9851);         /* call 0x10076730 */
            ii(0x100d_ff81, 5);  call(0x1016_3b41, 0x8_3bbb);          /* call 0x10163b41 */
            ii(0x100d_ff86, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100d_ff89, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_ff8c, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x100d_ff90, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100d_ff93, 5);  call(0x1007_6730, -0x6_9868);         /* call 0x10076730 */
            ii(0x100d_ff98, 5);  call(0x1016_3b41, 0x8_3ba4);          /* call 0x10163b41 */
            ii(0x100d_ff9d, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100d_ffa0, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_ffa3, 4);  movsx(ecx, memw[ss, ebp - 40]);       /* movsx ecx, word [ebp-0x28] */
            ii(0x100d_ffa7, 4);  movsx(ebx, memw[ss, ebp - 32]);       /* movsx ebx, word [ebp-0x20] */
            ii(0x100d_ffab, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x100d_ffaf, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x100d_ffb3, 5);  call(0x100d_8248, -0x7d70);           /* call 0x100d8248 */
            ii(0x100d_ffb8, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_ffbb, 4);  cmp(memb[ss, ebp - 4], 9);            /* cmp byte [ebp-0x4], 0x9 */
            ii(0x100d_ffbf, 2);  if(jnz(0x100d_ffc9, 8)) goto l_0x100d_ffc9;/* jnz 0x100dffc9 */
            ii(0x100d_ffc1, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_ffc4, 3);  sub(memd[ss, ebp - 44], eax);         /* sub [ebp-0x2c], eax */
            ii(0x100d_ffc7, 2);  jmp(0x100d_ffcf, 6); goto l_0x100d_ffcf;/* jmp 0x100dffcf */
        l_0x100d_ffc9:
            ii(0x100d_ffc9, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_ffcc, 3);  add(memd[ss, ebp - 44], eax);         /* add [ebp-0x2c], eax */
        l_0x100d_ffcf:
            ii(0x100d_ffcf, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x100d_ffd3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_ffd6, 5);  call(0x1007_6730, -0x6_98ab);         /* call 0x10076730 */
            ii(0x100d_ffdb, 5);  call(0x1016_3b41, 0x8_3b61);          /* call 0x10163b41 */
            ii(0x100d_ffe0, 3);  movsx(ecx, memw[ds, eax]);            /* movsx ecx, word [eax] */
            ii(0x100d_ffe3, 4);  movsx(ebx, memw[ss, ebp - 32]);       /* movsx ebx, word [ebp-0x20] */
            ii(0x100d_ffe7, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x100d_ffeb, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x100d_ffef, 5);  call(0x100d_8248, -0x7dac);           /* call 0x100d8248 */
            ii(0x100d_fff4, 3);  sub(eax, memd[ss, ebp - 48]);         /* sub eax, [ebp-0x30] */
            ii(0x100d_fff7, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_fffa, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fffe, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100e_0004, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_000a, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100e_000f, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100e_0012, 6);  if(jnz(0x100e_008d, 0x75)) goto l_0x100e_008d;/* jnz 0x100e008d */
            ii(0x100e_0018, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x100e_001d, 5);  call(0x1007_5fdc, -0x6_a046);         /* call 0x10075fdc */
            ii(0x100e_0022, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x100e_0025, 2);  jmp(0x100e_0071, 0x4a); goto l_0x100e_0071;/* jmp 0x100e0071 */
        l_0x100e_0027:
            ii(0x100e_0027, 4);  movsx(edx, memw[ss, ebp - 48]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100e_002b, 3);  lea(edx, memd[ds, edx + edx * 4]);    /* lea edx, [edx+edx*4] */
            ii(0x100e_002e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_0030, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_0033, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100e_0036, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x100e_0038, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x100e_003b, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100e_003e, 2);  jmp(0x100e_008d, 0x4d); goto l_0x100e_008d;/* jmp 0x100e008d */
        l_0x100e_0040:
            ii(0x100e_0040, 4);  movsx(edx, memw[ss, ebp - 48]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100e_0044, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100e_0047, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100e_004c, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_004e, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_0051, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100e_0053, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100e_0056, 2);  jmp(0x100e_008d, 0x35); goto l_0x100e_008d;/* jmp 0x100e008d */
        l_0x100e_0058:
            ii(0x100e_0058, 4);  movsx(edx, memw[ss, ebp - 48]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100e_005c, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x100e_005e, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100e_0063, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_0065, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_0068, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100e_006a, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100e_006d, 2);  jmp(0x100e_008d, 0x1e); goto l_0x100e_008d;/* jmp 0x100e008d */
        l_0x100e_006f:
            ii(0x100e_006f, 2);  jmp(0x100e_008d, 0x1c); goto l_0x100e_008d;/* jmp 0x100e008d */
        l_0x100e_0071:
            ii(0x100e_0071, 4);  cmp(memd[ss, ebp - 52], 4);           /* cmp dword [ebp-0x34], 0x4 */
            ii(0x100e_0075, 2);  if(jb(0x100e_0085, 0xe)) goto l_0x100e_0085;/* jb 0x100e0085 */
            ii(0x100e_0077, 4);  cmp(memd[ss, ebp - 52], 4);           /* cmp dword [ebp-0x34], 0x4 */
            ii(0x100e_007b, 2);  if(jbe(0x100e_0040, -0x3d)) goto l_0x100e_0040;/* jbe 0x100e0040 */
            ii(0x100e_007d, 4);  cmp(memd[ss, ebp - 52], 5);           /* cmp dword [ebp-0x34], 0x5 */
            ii(0x100e_0081, 2);  if(jz(0x100e_0058, -0x2b)) goto l_0x100e_0058;/* jz 0x100e0058 */
            ii(0x100e_0083, 2);  jmp(0x100e_006f, -0x16); goto l_0x100e_006f;/* jmp 0x100e006f */
        l_0x100e_0085:
            ii(0x100e_0085, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100e_0089, 2);  if(jz(0x100e_0027, -0x64)) goto l_0x100e_0027;/* jz 0x100e0027 */
            ii(0x100e_008b, 2);  jmp(0x100e_006f, -0x1e); goto l_0x100e_006f;/* jmp 0x100e006f */
        l_0x100e_008d:
            ii(0x100e_008d, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100e_0091, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100e_0094, 2);  if(jge(0x100e_009d, 7)) goto l_0x100e_009d;/* jge 0x100e009d */
            ii(0x100e_0096, 7);  mov(memd[ss, ebp - 48], 1);           /* mov dword [ebp-0x30], 0x1 */
        l_0x100e_009d:
            ii(0x100e_009d, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100e_00a0, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x100e_00a3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_00a5, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100e_00a8, 5);  call(0x1007_5eec, -0x6_a1c1);         /* call 0x10075eec */
            ii(0x100e_00ad, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_00af, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_00b2, 5);  call(0x1007_5eec, -0x6_a1cb);         /* call 0x10075eec */
            ii(0x100e_00b7, 2);  jmp(0x100e_00cd, 0x14); goto l_0x100e_00cd;/* jmp 0x100e00cd */
        //  ii(0x100e_00b9, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x100e_00bb, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
        //  ii(0x100e_00be, 5);  call(0x1007_5eec, -0x6_a1d7);         /* call 0x10075eec */
        //  ii(0x100e_00c3, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x100e_00c5, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
        //  ii(0x100e_00c8, 5);  call(0x1007_5eec, -0x6_a1e1);         /* call 0x10075eec */
        l_0x100e_00cd:
            ii(0x100e_00cd, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100e_00d0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_00d2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_00d3, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_00d4, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_00d5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_00d6, 1);  ret();                                /* ret */
        }
    }
}

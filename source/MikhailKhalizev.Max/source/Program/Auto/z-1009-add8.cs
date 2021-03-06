using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_add8-213fd2ea")]
        public void Method_1009_add8()
        {
            ii(0x1009_add8, 5);  push(0x48);                           /* push 0x48 */
            ii(0x1009_addd, 5);  call(Definitions.sys_check_available_stack_size, 0xc_af70);/* call 0x10165d52 */
            ii(0x1009_ade2, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_ade3, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_ade4, 1);  push(esi);                            /* push esi */
            ii(0x1009_ade5, 1);  push(edi);                            /* push edi */
            ii(0x1009_ade6, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_ade7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_ade9, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1009_adef, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_adf2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_adf5, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_adf8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_adfb, 5);  call(0x1015_2a52, 0xb_7c52);          /* call 0x10152a52 */
            ii(0x1009_ae00, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_ae02, 2);  if(jnz(0x1009_ae0d, 9)) goto l_0x1009_ae0d;/* jnz 0x1009ae0d */
            ii(0x1009_ae04, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_ae08, 5);  jmp(0x1009_afee, 0x1e1); goto l_0x1009_afee;/* jmp 0x1009afee */
        l_0x1009_ae0d:
            ii(0x1009_ae0d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ae10, 5);  call(0x1008_aa4c, -0x1_03c9);         /* call 0x1008aa4c */
            ii(0x1009_ae15, 2);  cmp(al, 1);                           /* cmp al, 0x1 */
            ii(0x1009_ae17, 2);  if(jnz(0x1009_ae34, 0x1b)) goto l_0x1009_ae34;/* jnz 0x1009ae34 */
            ii(0x1009_ae19, 5);  mov(ebx, 0x2b);                       /* mov ebx, 0x2b */
            ii(0x1009_ae1e, 5);  mov(edx, 0x1d);                       /* mov edx, 0x1d */
            ii(0x1009_ae23, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ae26, 5);  call(0x1016_3053, 0xc_8228);          /* call 0x10163053 */
            ii(0x1009_ae2b, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_ae2f, 5);  jmp(0x1009_afee, 0x1ba); goto l_0x1009_afee;/* jmp 0x1009afee */
        l_0x1009_ae34:
            ii(0x1009_ae34, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_ae36, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ae39, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_ae3c, 5);  call(0x1013_ad11, 0x9_fed0);          /* call 0x1013ad11 */
            ii(0x1009_ae41, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_ae43, 2);  if(jnz(0x1009_ae5c, 0x17)) goto l_0x1009_ae5c;/* jnz 0x1009ae5c */
            ii(0x1009_ae45, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ae48, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_ae4b, 5);  call(0x1007_6574, -0x2_48dc);         /* call 0x10076574 */
            ii(0x1009_ae50, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1009_ae53, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_ae58, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_ae5a, 2);  if(jg(0x1009_ae6d, 0x11)) goto l_0x1009_ae6d;/* jg 0x1009ae6d */
        l_0x1009_ae5c:
            ii(0x1009_ae5c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ae5f, 5);  call(0x1009_a476, -0x9ee);            /* call 0x1009a476 */
            ii(0x1009_ae64, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_ae68, 5);  jmp(0x1009_afee, 0x181); goto l_0x1009_afee;/* jmp 0x1009afee */
        l_0x1009_ae6d:
            ii(0x1009_ae6d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ae70, 5);  call(0x1007_623c, -0x2_4c39);         /* call 0x1007623c */
            ii(0x1009_ae75, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_ae78, 4);  mov(dx, memw[ds, edx + 82]);          /* mov dx, [edx+0x52] */
            ii(0x1009_ae7c, 4);  cmp(dx, memw[ds, eax + 25]);          /* cmp dx, [eax+0x19] */
            ii(0x1009_ae80, 2);  if(jnz(0x1009_ae95, 0x13)) goto l_0x1009_ae95;/* jnz 0x1009ae95 */
            ii(0x1009_ae82, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_ae85, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ae88, 5);  call(0x1009_a57f, -0x90e);            /* call 0x1009a57f */
            ii(0x1009_ae8d, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1009_ae90, 5);  jmp(0x1009_afee, 0x159); goto l_0x1009_afee;/* jmp 0x1009afee */
        l_0x1009_ae95:
            ii(0x1009_ae95, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ae98, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_ae9b, 5);  call(0x1007_6574, -0x2_492c);         /* call 0x10076574 */
            ii(0x1009_aea0, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_aea3, 4);  mov(dx, memw[ds, edx + 26]);          /* mov dx, [edx+0x1a] */
            ii(0x1009_aea7, 4);  cmp(dx, memw[ds, eax + 26]);          /* cmp dx, [eax+0x1a] */
            ii(0x1009_aeab, 2);  if(jnz(0x1009_aec5, 0x18)) goto l_0x1009_aec5;/* jnz 0x1009aec5 */
            ii(0x1009_aead, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_aeb0, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_aeb3, 5);  call(0x1007_6574, -0x2_4944);         /* call 0x10076574 */
            ii(0x1009_aeb8, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_aebb, 4);  mov(dx, memw[ds, edx + 28]);          /* mov dx, [edx+0x1c] */
            ii(0x1009_aebf, 4);  cmp(dx, memw[ds, eax + 28]);          /* cmp dx, [eax+0x1c] */
            ii(0x1009_aec3, 2);  if(jz(0x1009_aec7, 2)) goto l_0x1009_aec7;/* jz 0x1009aec7 */
        l_0x1009_aec5:
            ii(0x1009_aec5, 2);  jmp(0x1009_af0f, 0x48); goto l_0x1009_af0f;/* jmp 0x1009af0f */
        l_0x1009_aec7:
            ii(0x1009_aec7, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1009_aec9, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x1009_aece, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_aed0, 2);  if(jnz(0x1009_aee7, 0x15)) goto l_0x1009_aee7;/* jnz 0x1009aee7 */
            ii(0x1009_aed2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_aed5, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_aed8, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_aedb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_aedd, 6);  mov(dl, memb[ds, 0x101c_37c8]);       /* mov dl, [0x101c37c8] */
            ii(0x1009_aee3, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_aee5, 2);  if(jnz(0x1009_af06, 0x1f)) goto l_0x1009_af06;/* jnz 0x1009af06 */
        l_0x1009_aee7:
            ii(0x1009_aee7, 5);  mov(ebx, 0x2d);                       /* mov ebx, 0x2d */
            ii(0x1009_aeec, 5);  mov(edx, 0x1d);                       /* mov edx, 0x1d */
            ii(0x1009_aef1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_aef4, 5);  call(0x1016_3053, 0xc_815a);          /* call 0x10163053 */
            ii(0x1009_aef9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_aefb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_aefe, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_af01, 5);  call(0x1007_6630, -0x2_48d6);         /* call 0x10076630 */
        l_0x1009_af06:
            ii(0x1009_af06, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_af0a, 5);  jmp(0x1009_afee, 0xdf); goto l_0x1009_afee;/* jmp 0x1009afee */
        l_0x1009_af0f:
            ii(0x1009_af0f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_af12, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1009_af15, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_af1a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_af1c, 2);  if(jnz(0x1009_af27, 9)) goto l_0x1009_af27;/* jnz 0x1009af27 */
            ii(0x1009_af1e, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_af22, 5);  jmp(0x1009_afee, 0xc7); goto l_0x1009_afee;/* jmp 0x1009afee */
        l_0x1009_af27:
            ii(0x1009_af27, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1009_af2c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_af2f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_af32, 5);  call(0x100a_3671, 0x873a);            /* call 0x100a3671 */
            ii(0x1009_af37, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_af39, 2);  if(jz(0x1009_af44, 9)) goto l_0x1009_af44;/* jz 0x1009af44 */
            ii(0x1009_af3b, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_af3f, 5);  jmp(0x1009_afee, 0xaa); goto l_0x1009_afee;/* jmp 0x1009afee */
        l_0x1009_af44:
            ii(0x1009_af44, 5);  mov(eax, 0x49);                       /* mov eax, 0x49 */
            ii(0x1009_af49, 5);  call(Definitions.sys_new, 0xc_aeb2);  /* call 0x10165e00 */
            ii(0x1009_af4e, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_af51, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_af54, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_af57, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_af5b, 2);  if(jz(0x1009_afaf, 0x52)) goto l_0x1009_afaf;/* jz 0x1009afaf */
            ii(0x1009_af5d, 5);  mov(eax, 0x1009_a542);                /* mov eax, 0x1009a542 */
            ii(0x1009_af62, 1);  push(eax);                            /* push eax */
            ii(0x1009_af63, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_af66, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_af69, 5);  call(0x1007_6574, -0x2_49fa);         /* call 0x10076574 */
            ii(0x1009_af6e, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1009_af71, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_af74, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_af77, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_af7a, 5);  call(0x1007_6574, -0x2_4a0b);         /* call 0x10076574 */
            ii(0x1009_af7f, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1009_af82, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_af85, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_af88, 5);  call(0x1007_6aac, -0x2_44e1);         /* call 0x10076aac */
            ii(0x1009_af8d, 1);  push(eax);                            /* push eax */
            ii(0x1009_af8e, 5);  mov(eax, 3);                          /* mov eax, 0x3 */
            ii(0x1009_af93, 1);  push(eax);                            /* push eax */
            ii(0x1009_af94, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1009_af96, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1009_af99, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_af9c, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_af9f, 5);  call(0x100a_c220, 0x1_127c);          /* call 0x100ac220 */
            ii(0x1009_afa4, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_afa7, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_afaa, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1009_afad, 2);  jmp(0x1009_afb5, 6); goto l_0x1009_afb5;/* jmp 0x1009afb5 */
        l_0x1009_afaf:
            ii(0x1009_afaf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_afb2, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
        l_0x1009_afb5:
            ii(0x1009_afb5, 3);  mov(edx, memd[ss, ebp - 36]);         /* mov edx, [ebp-0x24] */
            ii(0x1009_afb8, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_afbb, 5);  call(0x1008_b060, -0xff60);           /* call 0x1008b060 */
            ii(0x1009_afc0, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_afc3, 5);  call(0x1008_af84, -0x1_0044);         /* call 0x1008af84 */
            ii(0x1009_afc8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_afca, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_afcf, 5);  call(0x100a_4d50, 0x9d7c);            /* call 0x100a4d50 */
            ii(0x1009_afd4, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_afd8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_afda, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_afdd, 5);  call(0x1008_8b7c, -0x1_2466);         /* call 0x10088b7c */
            ii(0x1009_afe2, 2);  jmp(0x1009_afee, 0xa); goto l_0x1009_afee;/* jmp 0x1009afee */
        //  ii(0x1009_afe4, 10);  Недостижимый код.
        l_0x1009_afee:
            ii(0x1009_afee, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1009_aff1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_aff3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_aff4, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_aff5, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_aff6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_aff7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_aff8, 1);  ret();                                /* ret */
        }
    }
}

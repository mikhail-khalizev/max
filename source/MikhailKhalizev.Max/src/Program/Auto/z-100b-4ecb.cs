using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_4ecb-3541f2a")]
        public void Method_100b_4ecb()
        {
            ii(0x100b_4ecb, 5); push(0x5c);                             /* push 0x5c */
            ii(0x100b_4ed0, 5); call(Definitions.sys_check_available_stack_size, 0xb_0e7d); /* call 0x10165d52 */
            ii(0x100b_4ed5, 1); push(ecx);                              /* push ecx */
            ii(0x100b_4ed6, 1); push(esi);                              /* push esi */
            ii(0x100b_4ed7, 1); push(edi);                              /* push edi */
            ii(0x100b_4ed8, 1); push(ebp);                              /* push ebp */
            ii(0x100b_4ed9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_4edb, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100b_4ee1, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100b_4ee4, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100b_4ee7, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100b_4eea, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_4eed, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100b_4ef0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4ef2, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_4ef5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4ef8, 5); call(0x1013_ad11, 0x8_5e14);            /* call 0x1013ad11 */
            ii(0x100b_4efd, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4eff, 2); if(jnz(0x100b_4f12, 0x11)) goto l_0x100b_4f12; /* jnz 0x100b4f12 */
            ii(0x100b_4f01, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4f03, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_4f06, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4f09, 5); call(0x1013_ad11, 0x8_5e03);            /* call 0x1013ad11 */
            ii(0x100b_4f0e, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4f10, 2); if(jz(0x100b_4f17, 5)) goto l_0x100b_4f17; /* jz 0x100b4f17 */
        l_0x100b_4f12:
            ii(0x100b_4f12, 5); jmp(0x100b_5135, 0x21e); goto l_0x100b_5135; /* jmp 0x100b5135 */
        l_0x100b_4f17:
            ii(0x100b_4f17, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100b_4f1b, 2); if(jnz(0x100b_4f33, 0x16)) goto l_0x100b_4f33; /* jnz 0x100b4f33 */
            ii(0x100b_4f1d, 5); call(0x1008_b0e4, -0x2_9e3e);           /* call 0x1008b0e4 */
            ii(0x100b_4f22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4f24, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_4f26, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_4f29, 5); call(0x100a_297d, -0x1_25b1);           /* call 0x100a297d */
            ii(0x100b_4f2e, 5); jmp(0x100b_5135, 0x202); goto l_0x100b_5135; /* jmp 0x100b5135 */
        l_0x100b_4f33:
            ii(0x100b_4f33, 4); cmp(memb[ss, ebp - 4], 2);              /* cmp byte [ebp-0x4], 0x2 */
            ii(0x100b_4f37, 6); if(jnz(0x100b_5135, 0x1f8)) goto l_0x100b_5135; /* jnz 0x100b5135 */
            ii(0x100b_4f3d, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100b_4f40, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100b_4f43, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_4f46, 5); call(0x1007_6668, -0x3_e8e3);           /* call 0x10076668 */
            ii(0x100b_4f4b, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100b_4f4e, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100b_4f51, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100b_4f54, 5); call(0x1007_6668, -0x3_e8f1);           /* call 0x10076668 */
            ii(0x100b_4f59, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_4f5c, 5); call(0x1007_6574, -0x3_e9ed);           /* call 0x10076574 */
            ii(0x100b_4f61, 3); mov(al, memb[ds, eax + 78]);            /* mov al, [eax+0x4e] */
            ii(0x100b_4f64, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_4f69, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_4f6b, 2); if(jz(0x100b_4f81, 0x14)) goto l_0x100b_4f81; /* jz 0x100b4f81 */
            ii(0x100b_4f6d, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100b_4f70, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_4f73, 5); call(0x1007_6574, -0x3_ea04);           /* call 0x10076574 */
            ii(0x100b_4f78, 5); call(0x1015_2a52, 0x9_dad5);            /* call 0x10152a52 */
            ii(0x100b_4f7d, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4f7f, 2); if(jnz(0x100b_4f9d, 0x1c)) goto l_0x100b_4f9d; /* jnz 0x100b4f9d */
        l_0x100b_4f81:
            ii(0x100b_4f81, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_4f86, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_4f89, 5); call(0x1007_65d0, -0x3_e9be);           /* call 0x100765d0 */
            ii(0x100b_4f8e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4f90, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_4f93, 5); call(0x100b_513c, 0x1a4);               /* call 0x100b513c */
            ii(0x100b_4f98, 5); jmp(0x100b_5121, 0x184); goto l_0x100b_5121; /* jmp 0x100b5121 */
        l_0x100b_4f9d:
            ii(0x100b_4f9d, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100b_4fa0, 5); call(0x1007_6574, -0x3_ea31);           /* call 0x10076574 */
            ii(0x100b_4fa5, 3); mov(al, memb[ds, eax + 78]);            /* mov al, [eax+0x4e] */
            ii(0x100b_4fa8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_4fad, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_4faf, 6); if(jz(0x100b_5031, 0x7c)) goto l_0x100b_5031; /* jz 0x100b5031 */
            ii(0x100b_4fb5, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100b_4fb8, 5); call(0x1007_65d0, -0x3_e9ed);           /* call 0x100765d0 */
            ii(0x100b_4fbd, 5); call(0x100a_2edb, -0x1_20e7);           /* call 0x100a2edb */
            ii(0x100b_4fc2, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4fc4, 2); if(jz(0x100b_500d, 0x47)) goto l_0x100b_500d; /* jz 0x100b500d */
            ii(0x100b_4fc6, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100b_4fc9, 5); call(0x1007_6574, -0x3_ea5a);           /* call 0x10076574 */
            ii(0x100b_4fce, 5); call(0x1015_26ac, 0x9_d6d9);            /* call 0x101526ac */
            ii(0x100b_4fd3, 3); cmp(eax, memd[ss, ebp - 16]);           /* cmp eax, [ebp-0x10] */
            ii(0x100b_4fd6, 2); if(jz(0x100b_4fe9, 0x11)) goto l_0x100b_4fe9; /* jz 0x100b4fe9 */
            ii(0x100b_4fd8, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100b_4fdb, 5); call(0x1007_6574, -0x3_ea6c);           /* call 0x10076574 */
            ii(0x100b_4fe0, 5); call(0x1015_26ac, 0x9_d6c7);            /* call 0x101526ac */
            ii(0x100b_4fe5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_4fe7, 2); if(jnz(0x100b_4feb, 2)) goto l_0x100b_4feb; /* jnz 0x100b4feb */
        l_0x100b_4fe9:
            ii(0x100b_4fe9, 2); jmp(0x100b_500b, 0x20); goto l_0x100b_500b; /* jmp 0x100b500b */
        l_0x100b_4feb:
            ii(0x100b_4feb, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100b_4fee, 5); call(0x1007_6574, -0x3_ea7f);           /* call 0x10076574 */
            ii(0x100b_4ff3, 5); call(0x1015_26ac, 0x9_d6b4);            /* call 0x101526ac */
            ii(0x100b_4ff8, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100b_4ffb, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100b_4ffe, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100b_5001, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100b_5004, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x100b_5007, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_5009, 2); if(jnz(0x100b_500d, 2)) goto l_0x100b_500d; /* jnz 0x100b500d */
        l_0x100b_500b:
            ii(0x100b_500b, 2); jmp(0x100b_500f, 2); goto l_0x100b_500f; /* jmp 0x100b500f */
        l_0x100b_500d:
            ii(0x100b_500d, 2); jmp(0x100b_502c, 0x1d); goto l_0x100b_502c; /* jmp 0x100b502c */
        l_0x100b_500f:
            ii(0x100b_500f, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x100b_5014, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_5017, 5); call(0x1007_65d0, -0x3_ea4c);           /* call 0x100765d0 */
            ii(0x100b_501c, 3); mov(ecx, memd[ss, ebp - 16]);           /* mov ecx, [ebp-0x10] */
            ii(0x100b_501f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5021, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_5023, 5); call(0x100a_346a, -0x1_1bbe);           /* call 0x100a346a */
            ii(0x100b_5028, 2); test(al, al);                           /* test al, al */
            ii(0x100b_502a, 2); if(jz(0x100b_5031, 5)) goto l_0x100b_5031; /* jz 0x100b5031 */
        l_0x100b_502c:
            ii(0x100b_502c, 5); jmp(0x100b_5121, 0xf0); goto l_0x100b_5121; /* jmp 0x100b5121 */
        l_0x100b_5031:
            ii(0x100b_5031, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x100b_5034, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_e549); /* call 0x10076af0 */
            ii(0x100b_5039, 3); lea(ebx, memd[ss, ebp - 32]);           /* lea ebx, [ebp-0x20] */
            ii(0x100b_503c, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100b_503f, 5); call(0x1007_65d0, -0x3_ea74);           /* call 0x100765d0 */
            ii(0x100b_5044, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5046, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_5049, 5); call(0x1007_65d0, -0x3_ea7e);           /* call 0x100765d0 */
            ii(0x100b_504e, 5); call(0x100b_49e3, -0x670);              /* call 0x100b49e3 */
            ii(0x100b_5053, 2); test(al, al);                           /* test al, al */
            ii(0x100b_5055, 2); if(jnz(0x100b_5073, 0x1c)) goto l_0x100b_5073; /* jnz 0x100b5073 */
            ii(0x100b_5057, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100b_505c, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_505f, 5); call(0x1007_65d0, -0x3_ea94);           /* call 0x100765d0 */
            ii(0x100b_5064, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5066, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_5069, 5); call(0x100b_513c, 0xce);                /* call 0x100b513c */
            ii(0x100b_506e, 5); jmp(0x100b_5121, 0xae); goto l_0x100b_5121; /* jmp 0x100b5121 */
        l_0x100b_5073:
            ii(0x100b_5073, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_5078, 5); call(Definitions.sys_new, 0xb_0d83);    /* call 0x10165e00 */
            ii(0x100b_507d, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100b_5080, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100b_5083, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100b_5086, 4); cmp(memd[ss, ebp - 40], 0);             /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100b_508a, 2); if(jz(0x100b_50c6, 0x3a)) goto l_0x100b_50c6; /* jz 0x100b50c6 */
            ii(0x100b_508c, 5); mov(eax, 0x100b_513c);                  /* mov eax, 0x100b513c */
            ii(0x100b_5091, 1); push(eax);                              /* push eax */
            ii(0x100b_5092, 3); lea(edx, memd[ss, ebp - 32]);           /* lea edx, [ebp-0x20] */
            ii(0x100b_5095, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100b_5098, 5); call(0x1007_5e64, -0x3_f239);           /* call 0x10075e64 */
            ii(0x100b_509d, 1); push(eax);                              /* push eax */
            ii(0x100b_509e, 5); mov(eax, 3);                            /* mov eax, 0x3 */
            ii(0x100b_50a3, 1); push(eax);                              /* push eax */
            ii(0x100b_50a4, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100b_50a6, 3); mov(ebx, memd[ss, ebp - 16]);           /* mov ebx, [ebp-0x10] */
            ii(0x100b_50a9, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_50ac, 5); call(0x1007_65d0, -0x3_eae1);           /* call 0x100765d0 */
            ii(0x100b_50b1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_50b3, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100b_50b6, 5); call(0x100a_c220, -0x8e9b);             /* call 0x100ac220 */
            ii(0x100b_50bb, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x100b_50be, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x100b_50c1, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100b_50c4, 2); jmp(0x100b_50cc, 6); goto l_0x100b_50cc; /* jmp 0x100b50cc */
        l_0x100b_50c6:
            ii(0x100b_50c6, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100b_50c9, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
        l_0x100b_50cc:
            ii(0x100b_50cc, 3); mov(edx, memd[ss, ebp - 52]);           /* mov edx, [ebp-0x34] */
            ii(0x100b_50cf, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100b_50d2, 5); call(0x1008_a5f0, -0x2_aae7);           /* call 0x1008a5f0 */
            ii(0x100b_50d7, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100b_50da, 5); call(0x1007_6574, -0x3_eb6b);           /* call 0x10076574 */
            ii(0x100b_50df, 4); test(memb[ds, eax + 19], 2);            /* test byte [eax+0x13], 0x2 */
            ii(0x100b_50e3, 2); if(jnz(0x100b_50eb, 6)) goto l_0x100b_50eb; /* jnz 0x100b50eb */
            ii(0x100b_50e5, 4); mov(memb[ss, ebp - 60], 1);             /* mov byte [ebp-0x3c], 0x1 */
            ii(0x100b_50e9, 2); jmp(0x100b_50ef, 4); goto l_0x100b_50ef; /* jmp 0x100b50ef */
        l_0x100b_50eb:
            ii(0x100b_50eb, 4); mov(memb[ss, ebp - 60], 0);             /* mov byte [ebp-0x3c], 0x0 */
        l_0x100b_50ef:
            ii(0x100b_50ef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_50f1, 3); mov(dl, memb[ss, ebp - 60]);            /* mov dl, [ebp-0x3c] */
            ii(0x100b_50f4, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100b_50f7, 5); call(0x1008_a520, -0x2_abdc);           /* call 0x1008a520 */
            ii(0x100b_50fc, 5); call(0x1008_a6a4, -0x2_aa5d);           /* call 0x1008a6a4 */
            ii(0x100b_5101, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100b_5104, 5); call(0x1008_a57c, -0x2_ab8d);           /* call 0x1008a57c */
            ii(0x100b_5109, 5); mov(ebx, 0x101c_3180);                  /* mov ebx, 0x101c3180 */
            ii(0x100b_510e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5110, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_5112, 5); call(0x100a_4d50, -0x1_03c7);           /* call 0x100a4d50 */
            ii(0x100b_5117, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5119, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100b_511c, 5); call(0x1008_8d4c, -0x2_c3d5);           /* call 0x10088d4c */
        l_0x100b_5121:
            ii(0x100b_5121, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5123, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100b_5126, 5); call(0x1007_5f2c, -0x3_f1ff);           /* call 0x10075f2c */
            ii(0x100b_512b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_512d, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_5130, 5); call(0x1007_5f2c, -0x3_f209);           /* call 0x10075f2c */
        l_0x100b_5135:
            ii(0x100b_5135, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5137, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_5138, 1); pop(edi);                               /* pop edi */
            ii(0x100b_5139, 1); pop(esi);                               /* pop esi */
            ii(0x100b_513a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_513b, 1); ret();                                  /* ret */
        }
    }
}

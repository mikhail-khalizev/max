using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f7521eb5-9fd8-4436-bdd4-664f77aaea5f")]
        public void Method_1010_facf()
        {
            ii(0x1010_facf, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1010_fad4, 5); calld(Definitions.sys_check_available_stack_size, 0x56279); /* call 0x10165d52 */
            ii(0x1010_fad9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_fada, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_fadb, 1); pushd(esi);                             /* push esi */
            ii(0x1010_fadc, 1); pushd(edi);                             /* push edi */
            ii(0x1010_fadd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_fade, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_fae0, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_fae6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_fae9, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1010_faec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_faef, 4); cmp(memd_a32[ds, eax + 0x15], 0);       /* cmp dword [eax+0x15], 0x0 */
            ii(0x1010_faf3, 6); if(jzd(0x1010_fcc5, 0x1cc)) goto l_0x1010_fcc5; /* jz 0x1010fcc5 */
            ii(0x1010_faf9, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_fafd, 6); if(jzd(0x1010_fc57, 0x154)) goto l_0x1010_fc57; /* jz 0x1010fc57 */
            ii(0x1010_fb03, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fb06, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1010_fb09, 5); calld(0x100e_b68a, -0x24484);           /* call 0x100eb68a */
            ii(0x1010_fb0e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fb11, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1010_fb14, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_fb17, 5); jmpd(0x1010_fc44, 0x128); goto l_0x1010_fc44; /* jmp 0x1010fc44 */
        l_0x1010_fb1c:
            ii(0x1010_fb1c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_fb1f, 6); add(edx, 0xe9);                         /* add edx, 0xe9 */
            ii(0x1010_fb25, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fb28, 5); add(eax, 0x125);                        /* add eax, 0x125 */
            ii(0x1010_fb2d, 5); calld(Definitions.sys_strcpy, 0x5639d); /* call 0x10165ecf */
            ii(0x1010_fb32, 5); mov(edx, StringDefinitions._3f8);       /* mov edx, 0x101a4652 */
            ii(0x1010_fb37, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fb3a, 5); add(eax, 0x125);                        /* add eax, 0x125 */
            ii(0x1010_fb3f, 5); calld(Definitions.sys_strstr, 0x694cc); /* call 0x10179010 */
            ii(0x1010_fb44, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_fb46, 2); if(jzd(0x1010_fb5d, 0x15)) goto l_0x1010_fb5d; /* jz 0x1010fb5d */
            ii(0x1010_fb48, 6); mov(edx, memd_a32[ds, 0x101b_ad54]);    /* mov edx, [0x101bad54] */
            ii(0x1010_fb4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fb51, 5); add(eax, 0x143);                        /* add eax, 0x143 */
            ii(0x1010_fb56, 5); calld(Definitions.sys_strcpy, 0x56374); /* call 0x10165ecf */
            ii(0x1010_fb5b, 2); jmpd(0x1010_fb86, 0x29); goto l_0x1010_fb86; /* jmp 0x1010fb86 */
        l_0x1010_fb5d:
            ii(0x1010_fb5d, 5); mov(edx, StringDefinitions._2f8);       /* mov edx, 0x101a4656 */
            ii(0x1010_fb62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fb65, 5); add(eax, 0x125);                        /* add eax, 0x125 */
            ii(0x1010_fb6a, 5); calld(Definitions.sys_strstr, 0x694a1); /* call 0x10179010 */
            ii(0x1010_fb6f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_fb71, 2); if(jzd(0x1010_fb86, 0x13)) goto l_0x1010_fb86; /* jz 0x1010fb86 */
            ii(0x1010_fb73, 6); mov(edx, memd_a32[ds, 0x101b_ad50]);    /* mov edx, [0x101bad50] */
            ii(0x1010_fb79, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fb7c, 5); add(eax, 0x143);                        /* add eax, 0x143 */
            ii(0x1010_fb81, 5); calld(Definitions.sys_strcpy, 0x56349); /* call 0x10165ecf */
        l_0x1010_fb86:
            ii(0x1010_fb86, 5); jmpd(0x1010_fc57, 0xcc); goto l_0x1010_fc57; /* jmp 0x1010fc57 */
        l_0x1010_fb8b:
            ii(0x1010_fb8b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_fb8e, 6); add(edx, 0xe9);                         /* add edx, 0xe9 */
            ii(0x1010_fb94, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fb97, 5); add(eax, 0x107);                        /* add eax, 0x107 */
            ii(0x1010_fb9c, 5); calld(Definitions.sys_strcpy, 0x5632e); /* call 0x10165ecf */
            ii(0x1010_fba1, 5); jmpd(0x1010_fc57, 0xb1); goto l_0x1010_fc57; /* jmp 0x1010fc57 */
        l_0x1010_fba6:
            ii(0x1010_fba6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_fba9, 6); add(edx, 0xe9);                         /* add edx, 0xe9 */
            ii(0x1010_fbaf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fbb2, 5); add(eax, 0x143);                        /* add eax, 0x143 */
            ii(0x1010_fbb7, 5); calld(Definitions.sys_strcpy, 0x56313); /* call 0x10165ecf */
            ii(0x1010_fbbc, 5); jmpd(0x1010_fc57, 0x96); goto l_0x1010_fc57; /* jmp 0x1010fc57 */
        l_0x1010_fbc1:
            ii(0x1010_fbc1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_fbc4, 6); add(edx, 0xe9);                         /* add edx, 0xe9 */
            ii(0x1010_fbca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fbcd, 5); add(eax, 0x161);                        /* add eax, 0x161 */
            ii(0x1010_fbd2, 5); calld(Definitions.sys_strcpy, 0x562f8); /* call 0x10165ecf */
            ii(0x1010_fbd7, 5); jmpd(0x1010_fc57, 0x7b); goto l_0x1010_fc57; /* jmp 0x1010fc57 */
        l_0x1010_fbdc:
            ii(0x1010_fbdc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_fbdf, 6); add(edx, 0xe9);                         /* add edx, 0xe9 */
            ii(0x1010_fbe5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fbe8, 5); add(eax, 0x17f);                        /* add eax, 0x17f */
            ii(0x1010_fbed, 5); calld(Definitions.sys_strcpy, 0x562dd); /* call 0x10165ecf */
            ii(0x1010_fbf2, 2); jmpd(0x1010_fc57, 0x63); goto l_0x1010_fc57; /* jmp 0x1010fc57 */
        l_0x1010_fbf4:
            ii(0x1010_fbf4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_fbf7, 6); add(edx, 0xe9);                         /* add edx, 0xe9 */
            ii(0x1010_fbfd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fc00, 5); add(eax, 0x19d);                        /* add eax, 0x19d */
            ii(0x1010_fc05, 5); calld(Definitions.sys_strcpy, 0x562c5); /* call 0x10165ecf */
            ii(0x1010_fc0a, 2); jmpd(0x1010_fc57, 0x4b); goto l_0x1010_fc57; /* jmp 0x1010fc57 */
        l_0x1010_fc0c:
            ii(0x1010_fc0c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_fc0f, 6); add(edx, 0xe9);                         /* add edx, 0xe9 */
            ii(0x1010_fc15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fc18, 5); add(eax, 0x1bb);                        /* add eax, 0x1bb */
            ii(0x1010_fc1d, 5); calld(Definitions.sys_strcpy, 0x562ad); /* call 0x10165ecf */
            ii(0x1010_fc22, 2); jmpd(0x1010_fc57, 0x33); goto l_0x1010_fc57; /* jmp 0x1010fc57 */
        l_0x1010_fc24:
            ii(0x1010_fc24, 2); jmpd(0x1010_fc57, 0x31); goto l_0x1010_fc57; /* jmp 0x1010fc57 */
        //    ii(0x1010_fc26, 2); /* Выравнивание. */
        //    ii(0x1010_fc28, 28); /* Служебная область с абсолютными адресами переходов. {0x1010_fb1c, 0x1010_fb8b, 0x1010_fba6, 0x1010_fbc1, 0x1010_fbdc, 0x1010_fbf4, 0x1010_fc0c}. */
        l_0x1010_fc44:
            ii(0x1010_fc44, 4); cmp(memd_a32[ss, ebp - 0xc], 0x6);      /* cmp dword [ebp-0xc], 0x6 */
            ii(0x1010_fc48, 2); if(jad(0x1010_fc24, -0x26)) goto l_0x1010_fc24; /* ja 0x1010fc24 */
            ii(0x1010_fc4a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_fc4d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_fc50, 7); 
            switch (jmpd_abs_switch(memd_a32[cs, eax + 0x1010_fc28]))
            {
                case 0x1010_fb1c:
                    goto l_0x1010_fb1c;
                case 0x1010_fb8b:
                    goto l_0x1010_fb8b;
                case 0x1010_fba6:
                    goto l_0x1010_fba6;
                case 0x1010_fbc1:
                    goto l_0x1010_fbc1;
                case 0x1010_fbdc:
                    goto l_0x1010_fbdc;
                case 0x1010_fbf4:
                    goto l_0x1010_fbf4;
                case 0x1010_fc0c:
                    goto l_0x1010_fc0c;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x1010fc28] */
        l_0x1010_fc57:
            ii(0x1010_fc57, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_fc59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fc5c, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1010_fc5f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_fc62, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_fc65, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1010_fc68, 5); calld(0x100c_fb73, -0x400fa);           /* call 0x100cfb73 */
            ii(0x1010_fc6d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fc70, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1010_fc73, 5); calld(0x100e_b226, -0x24a52);           /* call 0x100eb226 */
            ii(0x1010_fc78, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fc7b, 4); cmp(memd_a32[ds, eax + 0x15], 0);       /* cmp dword [eax+0x15], 0x0 */
            ii(0x1010_fc7f, 2); if(jzd(0x1010_fcb5, 0x34)) goto l_0x1010_fcb5; /* jz 0x1010fcb5 */
            ii(0x1010_fc81, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fc84, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1010_fc87, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_fc8a, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1010_fc8e, 2); if(jzd(0x1010_fca4, 0x14)) goto l_0x1010_fca4; /* jz 0x1010fca4 */
            ii(0x1010_fc90, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_fc92, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_fc95, 5); calld(Definitions.my_dtor_d6, -0x24bc3); /* call 0x100eb0d7 */
            ii(0x1010_fc9a, 5); calld(Definitions.sys_delete, 0x562c5); /* call 0x10165f64 */
            ii(0x1010_fc9f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_fca2, 2); jmpd(0x1010_fcab, 0x7); goto l_0x1010_fcab; /* jmp 0x1010fcab */
        l_0x1010_fca4:
            ii(0x1010_fca4, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1010_fcab:
            ii(0x1010_fcab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fcae, 7); mov(memd_a32[ds, eax + 0x15], 0);       /* mov dword [eax+0x15], 0x0 */
        l_0x1010_fcb5:
            ii(0x1010_fcb5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fcb8, 5); calld(0x1010_f23d, -0xa80);             /* call 0x1010f23d */
            ii(0x1010_fcbd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_fcc0, 5); calld(0x1010_ee3c, -0xe89);             /* call 0x1010ee3c */
        l_0x1010_fcc5:
            ii(0x1010_fcc5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_fcc7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_fcc8, 1); popd(edi);                              /* pop edi */
            ii(0x1010_fcc9, 1); popd(esi);                              /* pop esi */
            ii(0x1010_fcca, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_fccb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_fccc, 1); retd(); return;                         /* ret */
        }
    }
}

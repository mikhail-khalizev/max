using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ec763d95-63cd-47f5-aba7-8a9b589182e5")]
        public void /* sys */ Method_1018_1db8()
        {
            ii(0x1018_1db8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_1db9, 1); pushd(esi);                             /* push esi */
            ii(0x1018_1dba, 1); pushd(edi);                             /* push edi */
            ii(0x1018_1dbb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_1dbc, 3); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1018_1dbf, 1); pushd(eax);                             /* push eax */
            ii(0x1018_1dc0, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1018_1dc2, 4); lea(eax, esp + 0x4);                    /* lea eax, [esp+0x4] */
            ii(0x1018_1dc6, 5); calld(/* sys */ 0x1019_5c56, 0x13e8b);  /* call 0x10195c56 */
            ii(0x1018_1dcb, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1018_1dce, 4); mov(memd_a32[ss, esp + 0xd], eax);      /* mov [esp+0xd], eax */
            ii(0x1018_1dd2, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_1dd4, 2); if(jzd(0x1018_1ddf, 0x9)) goto l_0x1018_1ddf; /* jz 0x10181ddf */
            ii(0x1018_1dd6, 4); lea(eax, esp + 0x4);                    /* lea eax, [esp+0x4] */
            ii(0x1018_1dda, 5); calld(/* sys */ 0x1019_5c77, 0x13e98);  /* call 0x10195c77 */
        l_0x1018_1ddf:
            ii(0x1018_1ddf, 4); lea(eax, esp + 0x4);                    /* lea eax, [esp+0x4] */
            ii(0x1018_1de3, 3); mov(ebp, memd_a32[ds, edi + 0x4]);      /* mov ebp, [edi+0x4] */
            ii(0x1018_1de6, 5); calld(/* sys */ 0x1018_1d24, -0xc7);    /* call 0x10181d24 */
            ii(0x1018_1deb, 4); mov(memd_a32[ss, esp + 0x14], eax);     /* mov [esp+0x14], eax */
            ii(0x1018_1def, 2); jmpd(0x1018_1e59, 0x68); goto l_0x1018_1e59; /* jmp 0x10181e59 */
        l_0x1018_1df1:
            ii(0x1018_1df1, 5); calld(/* sys */ 0x1019_5dab, 0x13fb5);  /* call 0x10195dab */
        l_0x1018_1df6:
            ii(0x1018_1df6, 3); mov(eax, memd_a32[ss, ebp + 0]);        /* mov eax, [ebp] */
            ii(0x1018_1df9, 7); mov(ecx, memd_a32[ds, eax * 4 + 0x1020_a21c]); /* mov ecx, [eax*4+0x1020a21c] */
            ii(0x1018_1e00, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1018_1e02, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_1e04, 3); calld_abs(memd_a32[ds, ecx + 0x4]);     /* call dword [ecx+0x4] */
            ii(0x1018_1e07, 3); mov(ebx, memd_a32[ds, esi + 0xa]);      /* mov ebx, [esi+0xa] */
            ii(0x1018_1e0a, 3); mov(edx, memd_a32[ds, esi + 0x6]);      /* mov edx, [esi+0x6] */
            ii(0x1018_1e0d, 3); add(eax, memd_a32[ds, esi + 0x2]);      /* add eax, [esi+0x2] */
        l_0x1018_1e10:
            ii(0x1018_1e10, 5); calld(Definitions.sys_call_dtor_arr_v2, -0x1be35); /* call 0x10165fe0 */
            ii(0x1018_1e15, 2); jmpd(0x1018_1e59, 0x42); goto l_0x1018_1e59; /* jmp 0x10181e59 */
        l_0x1018_1e17:
            ii(0x1018_1e17, 5); mov(ecx, 0x11);                         /* mov ecx, 0x11 */
        l_0x1018_1e1c:
            ii(0x1018_1e1c, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1018_1e21, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1018_1e23, 2); mov(eax, esi);                          /* mov eax, esi */
        l_0x1018_1e25:
            ii(0x1018_1e25, 5); calld(/* sys */ 0x1018_1d6e, -0xbc);    /* call 0x10181d6e */
            ii(0x1018_1e2a, 2); jmpd(0x1018_1e59, 0x2d); goto l_0x1018_1e59; /* jmp 0x10181e59 */
        l_0x1018_1e2c:
            ii(0x1018_1e2c, 5); mov(ecx, 0x10);                         /* mov ecx, 0x10 */
            ii(0x1018_1e31, 2); jmpd(0x1018_1e1c, -0x17); goto l_0x1018_1e1c; /* jmp 0x10181e1c */
        l_0x1018_1e33:
            ii(0x1018_1e33, 5); mov(ecx, 0x10);                         /* mov ecx, 0x10 */
            ii(0x1018_1e38, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1018_1e3a, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_1e3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1e3e, 2); jmpd(0x1018_1e25, -0x1b); goto l_0x1018_1e25; /* jmp 0x10181e25 */
        l_0x1018_1e40:
            ii(0x1018_1e40, 3); mov(eax, memd_a32[ds, esi + 0x2]);      /* mov eax, [esi+0x2] */
            ii(0x1018_1e43, 4); mov(ebx, memd_a32[ds, edi + eax + 0x4]); /* mov ebx, [edi+eax+0x4] */
            ii(0x1018_1e47, 4); mov(edx, memd_a32[ds, edi + eax + 0x8]); /* mov edx, [edi+eax+0x8] */
            ii(0x1018_1e4b, 3); mov(eax, memd_a32[ds, edi + eax]);      /* mov eax, [edi+eax] */
            ii(0x1018_1e4e, 2); jmpd(0x1018_1e10, -0x40); goto l_0x1018_1e10; /* jmp 0x10181e10 */
        l_0x1018_1e50:
            ii(0x1018_1e50, 3); mov(eax, memd_a32[ds, esi + 0x2]);      /* mov eax, [esi+0x2] */
        l_0x1018_1e53:
            ii(0x1018_1e53, 3); mov(eax, memd_a32[ds, edi + eax]);      /* mov eax, [edi+eax] */
            ii(0x1018_1e56, 3); calld_abs(memd_a32[ds, esi + 0x6]);     /* call dword [esi+0x6] */
        l_0x1018_1e59:
            ii(0x1018_1e59, 4); mov(eax, memd_a32[ss, esp + 0x8]);      /* mov eax, [esp+0x8] */
            ii(0x1018_1e5d, 3); cmp(eax, memd_a32[ss, esp]);            /* cmp eax, [esp] */
            ii(0x1018_1e60, 6); if(jzd(0x1018_1edd, 0x77)) goto l_0x1018_1edd; /* jz 0x10181edd */
            ii(0x1018_1e66, 2); if(jaed(0x1018_1e6d, 0x5)) goto l_0x1018_1e6d; /* jae 0x10181e6d */
            ii(0x1018_1e68, 5); calld(/* sys */ 0x1019_5dab, 0x13f3e);  /* call 0x10195dab */
        l_0x1018_1e6d:
            ii(0x1018_1e6d, 4); lea(eax, esp + 0x4);                    /* lea eax, [esp+0x4] */
            ii(0x1018_1e71, 4); mov(ebx, memd_a32[ss, esp + 0x8]);      /* mov ebx, [esp+0x8] */
            ii(0x1018_1e75, 5); calld(/* sys */ 0x1019_5c7c, 0x13e02);  /* call 0x10195c7c */
            ii(0x1018_1e7a, 4); lea(eax, esp + 0x4);                    /* lea eax, [esp+0x4] */
            ii(0x1018_1e7e, 4); mov(edx, memd_a32[ss, esp + 0x14]);     /* mov edx, [esp+0x14] */
            ii(0x1018_1e82, 5); calld(/* sys */ 0x1018_1d24, -0x163);   /* call 0x10181d24 */
            ii(0x1018_1e87, 4); mov(memd_a32[ss, esp + 0x14], eax);     /* mov [esp+0x14], eax */
            ii(0x1018_1e8b, 4); mov(eax, memd_a32[ss, esp + 0x8]);      /* mov eax, [esp+0x8] */
            ii(0x1018_1e8f, 3); mov(memd_a32[ds, edi + 0x8], eax);      /* mov [edi+0x8], eax */
            ii(0x1018_1e92, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1018_1e94, 4); mov(memd_a32[ss, esp + 0x18], eax);     /* mov [esp+0x18], eax */
            ii(0x1018_1e98, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_1e9a, 2); if(jzd(0x1018_1ea6, 0xa)) goto l_0x1018_1ea6; /* jz 0x10181ea6 */
            ii(0x1018_1e9c, 2); jmpd(0x1018_1ec1, 0x23); goto l_0x1018_1ec1; /* jmp 0x10181ec1 */
        l_0x1018_1e9e:
            ii(0x1018_1e9e, 3); mov(eax, memd_a32[ds, esi + 0x2]);      /* mov eax, [esi+0x2] */
            ii(0x1018_1ea1, 3); mov(edx, memd_a32[ds, esi + 0xa]);      /* mov edx, [esi+0xa] */
            ii(0x1018_1ea4, 2); jmpd(0x1018_1e53, -0x53); goto l_0x1018_1e53; /* jmp 0x10181e53 */
        l_0x1018_1ea6:
            ii(0x1018_1ea6, 3); mov(esi, memd_a32[ds, edx + 0x4]);      /* mov esi, [edx+0x4] */
            ii(0x1018_1ea9, 3); mov(ax, memw_a32[ds, esi]);             /* mov ax, [esi] */
            ii(0x1018_1eac, 4); cmp(ax, 0xb);                           /* cmp ax, 0xb */
            ii(0x1018_1eb0, 6); if(jad(0x1018_1df1, -0xc5)) goto l_0x1018_1df1; /* ja 0x10181df1 */
            ii(0x1018_1eb6, 3); movzx(eax, ax);                         /* movzx eax, ax */
            ii(0x1018_1eb9, 8); 
            switch (jmpd_abs_switch(memd_a32[cs, eax * 4 + /* sys */ 0x1018_1d88]))
            {
                case 0x1018_1df1:
                    goto l_0x1018_1df1;
                case 0x1018_1df6:
                    goto l_0x1018_1df6;
                case 0x1018_1e17:
                    goto l_0x1018_1e17;
                case 0x1018_1e2c:
                    goto l_0x1018_1e2c;
                case 0x1018_1e33:
                    goto l_0x1018_1e33;
                case 0x1018_1e40:
                    goto l_0x1018_1e40;
                case 0x1018_1e50:
                    goto l_0x1018_1e50;
                case 0x1018_1e59:
                    goto l_0x1018_1e59;
                case 0x1018_1e9e:
                    goto l_0x1018_1e9e;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax*4+0x10181d88] */
        l_0x1018_1ec1:
            ii(0x1018_1ec1, 3); mov(esi, memd_a32[ss, ebp + 0]);        /* mov esi, [ebp] */
            ii(0x1018_1ec4, 7); mov(esi, memd_a32[ds, esi * 4 + 0x1020_a21c]); /* mov esi, [esi*4+0x1020a21c] */
            ii(0x1018_1ecb, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1018_1ecd, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_1ecf, 3); calld_abs(memd_a32[ds, esi + 0x4]);     /* call dword [esi+0x4] */
            ii(0x1018_1ed2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1ed4, 4); calld_abs(memd_a32[ss, esp + 0x18]);    /* call dword [esp+0x18] */
            ii(0x1018_1ed8, 5); jmpd(0x1018_1e59, -0x84); goto l_0x1018_1e59; /* jmp 0x10181e59 */
        l_0x1018_1edd:
            ii(0x1018_1edd, 3); mov(memd_a32[ds, edi + 0x8], eax);      /* mov [edi+0x8], eax */
            ii(0x1018_1ee0, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1018_1ee3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_1ee4, 1); popd(edi);                              /* pop edi */
            ii(0x1018_1ee5, 1); popd(esi);                              /* pop esi */
            ii(0x1018_1ee6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_1ee7, 1); retd(); return;                         /* ret */
        }
    }
}

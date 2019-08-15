using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ce5c18e5-ab9b-4ade-a213-1eefe3261846")]
        public void Method_100d_ad31()
        {
            ii(0x100d_ad31, 5); pushd(0x6c);                            /* push 0x6c */
            ii(0x100d_ad36, 5); calld(Definitions.sys_check_available_stack_size, 0x8_b017); /* call 0x10165d52 */
            ii(0x100d_ad3b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_ad3c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_ad3d, 1); pushd(esi);                             /* push esi */
            ii(0x100d_ad3e, 1); pushd(edi);                             /* push edi */
            ii(0x100d_ad3f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_ad40, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_ad42, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x100d_ad48, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_ad4b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_ad4e, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100d_ad52, 2); if(jled(0x100d_ad5d, 0x9)) goto l_0x100d_ad5d; /* jle 0x100dad5d */
            ii(0x100d_ad54, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_ad5b, 2); if(jld(0x100d_ad5f, 0x2)) goto l_0x100d_ad5f; /* jl 0x100dad5f */
        l_0x100d_ad5d:
            ii(0x100d_ad5d, 2); jmpd(0x100d_ad69, 0xa); goto l_0x100d_ad69; /* jmp 0x100dad69 */
        l_0x100d_ad5f:
            ii(0x100d_ad5f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ad62, 7); mov(memb_a32[ds, eax + 0x39e], 0);      /* mov byte [eax+0x39e], 0x0 */
        l_0x100d_ad69:
            ii(0x100d_ad69, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3f7);    /* cmp dword [ebp-0x4], 0x3f7 */
            ii(0x100d_ad70, 2); if(jld(0x100d_ad7b, 0x9)) goto l_0x100d_ad7b; /* jl 0x100dad7b */
            ii(0x100d_ad72, 7); cmp(memd_a32[ss, ebp - 0x4], 0x401);    /* cmp dword [ebp-0x4], 0x401 */
            ii(0x100d_ad79, 2); if(jld(0x100d_ad7d, 0x2)) goto l_0x100d_ad7d; /* jl 0x100dad7d */
        l_0x100d_ad7b:
            ii(0x100d_ad7b, 2); jmpd(0x100d_adb1, 0x34); goto l_0x100d_adb1; /* jmp 0x100dadb1 */
        l_0x100d_ad7d:
            ii(0x100d_ad7d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ad80, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_ad83, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100d_ad86, 6); mov(eax, memd_a32[ds, eax - 0xc67]);    /* mov eax, [eax-0xc67] */
            ii(0x100d_ad8c, 5); calld(0x100d_89c4, -0x23cd);            /* call 0x100d89c4 */
            ii(0x100d_ad91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ad94, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_ad97, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_ad9a, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_ad9d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ada0, 3); mov(edx, memd_a32[ds, eax + 0x57]);     /* mov edx, [eax+0x57] */
            ii(0x100d_ada3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_ada6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_ada9, 3); calld_abs(memd_a32[ds, ebx + 0x18]);    /* call dword [ebx+0x18] */
            ii(0x100d_adac, 5); jmpd(0x100d_b21a, 0x469); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_adb1:
            ii(0x100d_adb1, 7); cmp(memd_a32[ss, ebp - 0x4], 0x401);    /* cmp dword [ebp-0x4], 0x401 */
            ii(0x100d_adb8, 2); if(jld(0x100d_adc3, 0x9)) goto l_0x100d_adc3; /* jl 0x100dadc3 */
            ii(0x100d_adba, 7); cmp(memd_a32[ss, ebp - 0x4], 0x40b);    /* cmp dword [ebp-0x4], 0x40b */
            ii(0x100d_adc1, 2); if(jld(0x100d_adc5, 0x2)) goto l_0x100d_adc5; /* jl 0x100dadc5 */
        l_0x100d_adc3:
            ii(0x100d_adc3, 2); jmpd(0x100d_adf9, 0x34); goto l_0x100d_adf9; /* jmp 0x100dadf9 */
        l_0x100d_adc5:
            ii(0x100d_adc5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_adc8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_adcb, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100d_adce, 6); mov(eax, memd_a32[ds, eax - 0xc8f]);    /* mov eax, [eax-0xc8f] */
            ii(0x100d_add4, 5); calld(0x100d_8a62, -0x2377);            /* call 0x100d8a62 */
            ii(0x100d_add9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_addc, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_addf, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_ade2, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_ade5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ade8, 3); mov(edx, memd_a32[ds, eax + 0x57]);     /* mov edx, [eax+0x57] */
            ii(0x100d_adeb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_adee, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_adf1, 3); calld_abs(memd_a32[ds, ebx + 0x18]);    /* call dword [ebx+0x18] */
            ii(0x100d_adf4, 5); jmpd(0x100d_b21a, 0x421); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_adf9:
            ii(0x100d_adf9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_adfc, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_adff, 5); jmpd(0x100d_b124, 0x320); goto l_0x100d_b124; /* jmp 0x100db124 */
        l_0x100d_ae04:
            ii(0x100d_ae04, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ae07, 7); mov(memb_a32[ds, eax + 0x344], 0x1);    /* mov byte [eax+0x344], 0x1 */
            ii(0x100d_ae0e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ae11, 7); mov(memb_a32[ds, eax + 0x343], 0x1);    /* mov byte [eax+0x343], 0x1 */
            ii(0x100d_ae18, 5); jmpd(0x100d_b21a, 0x3fd); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_ae1d:
            ii(0x100d_ae1d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ae20, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_ae23, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_ae26, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_ae29, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_ae2c, 3); calld_abs(memd_a32[ds, edx + 0x1c]);    /* call dword [edx+0x1c] */
            ii(0x100d_ae2f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ae32, 7); mov(memb_a32[ds, eax + 0x343], 0x1);    /* mov byte [eax+0x343], 0x1 */
            ii(0x100d_ae39, 5); jmpd(0x100d_b21a, 0x3dc); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_ae3e:
            ii(0x100d_ae3e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ae41, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_ae47, 5); calld(0x100c_fbbe, -0xb28e);            /* call 0x100cfbbe */
            ii(0x100d_ae4c, 7); mov(memb_a32[ds, 0x101b_7ecc], 0x1);    /* mov byte [0x101b7ecc], 0x1 */
            ii(0x100d_ae53, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ae56, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_ae59, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_ae5c, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_ae5f, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_ae62, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_ae65, 5); jmpd(0x100d_b21a, 0x3b0); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_ae6a:
            ii(0x100d_ae6a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ae6d, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_ae73, 5); calld(0x100c_fbbe, -0xb2ba);            /* call 0x100cfbbe */
            ii(0x100d_ae78, 7); mov(memb_a32[ds, 0x101b_7ecc], 0);      /* mov byte [0x101b7ecc], 0x0 */
            ii(0x100d_ae7f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ae82, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100d_ae85, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_ae88, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_ae8b, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_ae8e, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_ae91, 5); jmpd(0x100d_b21a, 0x384); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_ae96:
            ii(0x100d_ae96, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ae99, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_ae9f, 5); calld(0x100c_fbbe, -0xb2e6);            /* call 0x100cfbbe */
            ii(0x100d_aea4, 7); mov(memb_a32[ds, 0x101b_7ecd], 0);      /* mov byte [0x101b7ecd], 0x0 */
            ii(0x100d_aeab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_aeae, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100d_aeb1, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100d_aeb4, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_aeb7, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100d_aeba, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_aebd, 5); jmpd(0x100d_b21a, 0x358); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_aec2:
            ii(0x100d_aec2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_aec5, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_aecb, 5); calld(0x100c_fbbe, -0xb312);            /* call 0x100cfbbe */
            ii(0x100d_aed0, 7); mov(memb_a32[ds, 0x101b_7ecd], 0x1);    /* mov byte [0x101b7ecd], 0x1 */
            ii(0x100d_aed7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_aeda, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100d_aedd, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100d_aee0, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_aee3, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100d_aee6, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_aee9, 5); jmpd(0x100d_b21a, 0x32c); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_aeee:
            ii(0x100d_aeee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_aef1, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_aef7, 5); calld(0x100c_fbbe, -0xb33e);            /* call 0x100cfbbe */
            ii(0x100d_aefc, 7); mov(memb_a32[ds, 0x101b_7ece], 0x1);    /* mov byte [0x101b7ece], 0x1 */
            ii(0x100d_af03, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_af06, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100d_af09, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100d_af0c, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_af0f, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100d_af12, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_af15, 5); jmpd(0x100d_b21a, 0x300); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_af1a:
            ii(0x100d_af1a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_af1d, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_af23, 5); calld(0x100c_fbbe, -0xb36a);            /* call 0x100cfbbe */
            ii(0x100d_af28, 7); mov(memb_a32[ds, 0x101b_7ece], 0);      /* mov byte [0x101b7ece], 0x0 */
            ii(0x100d_af2f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_af32, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100d_af35, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_af38, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_af3b, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_af3e, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_af41, 5); jmpd(0x100d_b21a, 0x2d4); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_af46:
            ii(0x100d_af46, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_af49, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_af4f, 5); calld(0x100c_fbbe, -0xb396);            /* call 0x100cfbbe */
            ii(0x100d_af54, 7); mov(memb_a32[ds, 0x101b_7ecf], 0x1);    /* mov byte [0x101b7ecf], 0x1 */
            ii(0x100d_af5b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_af5e, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100d_af61, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_af64, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_af67, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_af6a, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_af6d, 5); jmpd(0x100d_b21a, 0x2a8); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_af72:
            ii(0x100d_af72, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_af75, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_af7b, 5); calld(0x100c_fbbe, -0xb3c2);            /* call 0x100cfbbe */
            ii(0x100d_af80, 7); mov(memb_a32[ds, 0x101b_7ecf], 0);      /* mov byte [0x101b7ecf], 0x0 */
            ii(0x100d_af87, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_af8a, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100d_af8d, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100d_af90, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_af93, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100d_af96, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_af99, 5); jmpd(0x100d_b21a, 0x27c); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_af9e:
            ii(0x100d_af9e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_afa1, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_afa7, 5); calld(0x100c_fbbe, -0xb3ee);            /* call 0x100cfbbe */
            ii(0x100d_afac, 7); mov(memb_a32[ds, 0x101c_3604], 0x1);    /* mov byte [0x101c3604], 0x1 */
            ii(0x100d_afb3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_afb6, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100d_afb9, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100d_afbc, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_afbf, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100d_afc2, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_afc5, 5); jmpd(0x100d_b21a, 0x250); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_afca:
            ii(0x100d_afca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_afcd, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_afd3, 5); calld(0x100c_fbbe, -0xb41a);            /* call 0x100cfbbe */
            ii(0x100d_afd8, 7); mov(memb_a32[ds, 0x101c_3604], 0);      /* mov byte [0x101c3604], 0x0 */
            ii(0x100d_afdf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_afe2, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100d_afe5, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100d_afe8, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_afeb, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100d_afee, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_aff1, 5); jmpd(0x100d_b21a, 0x224); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_aff6:
            ii(0x100d_aff6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_aff9, 6); mov(eax, memd_a32[ds, eax + 0x371]);    /* mov eax, [eax+0x371] */
            ii(0x100d_afff, 5); calld(0x100c_fbbe, -0xb446);            /* call 0x100cfbbe */
            ii(0x100d_b004, 7); mov(memb_a32[ds, 0x101b_7ed0], 0x1);    /* mov byte [0x101b7ed0], 0x1 */
            ii(0x100d_b00b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b00e, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100d_b011, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100d_b014, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_b017, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b01a, 3); mov(edx, memd_a32[ds, eax + 0x57]);     /* mov edx, [eax+0x57] */
            ii(0x100d_b01d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_b020, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100d_b023, 3); calld_abs(memd_a32[ds, ebx + 0x8]);     /* call dword [ebx+0x8] */
            ii(0x100d_b026, 5); jmpd(0x100d_b21a, 0x1ef); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_b02b:
            ii(0x100d_b02b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b02e, 6); mov(eax, memd_a32[ds, eax + 0x371]);    /* mov eax, [eax+0x371] */
            ii(0x100d_b034, 5); calld(0x100c_fbbe, -0xb47b);            /* call 0x100cfbbe */
            ii(0x100d_b039, 7); mov(memb_a32[ds, 0x101b_7ed0], 0);      /* mov byte [0x101b7ed0], 0x0 */
            ii(0x100d_b040, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b043, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100d_b046, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100d_b049, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_b04c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b04f, 3); mov(edx, memd_a32[ds, eax + 0x57]);     /* mov edx, [eax+0x57] */
            ii(0x100d_b052, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_b055, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100d_b058, 3); calld_abs(memd_a32[ds, ebx + 0x8]);     /* call dword [ebx+0x8] */
            ii(0x100d_b05b, 5); jmpd(0x100d_b21a, 0x1ba); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_b060:
            ii(0x100d_b060, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_b067, 6); if(jld(0x100d_b0fc, 0x8f)) goto l_0x100d_b0fc; /* jl 0x100db0fc */
            ii(0x100d_b06d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b070, 7); cmp(memb_a32[ds, eax + 0x39e], 0);      /* cmp byte [eax+0x39e], 0x0 */
            ii(0x100d_b077, 6); if(jnzd(0x100d_b0f0, 0x73)) goto l_0x100d_b0f0; /* jnz 0x100db0f0 */
            ii(0x100d_b07d, 7); add(memd_a32[ss, ebp - 0x4], 0xffff_9000); /* add dword [ebp-0x4], 0xffff9000 */
            ii(0x100d_b084, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3e8);    /* cmp dword [ebp-0x4], 0x3e8 */
            ii(0x100d_b08b, 2); if(jnzd(0x100d_b09d, 0x10)) goto l_0x100d_b09d; /* jnz 0x100db09d */
            ii(0x100d_b08d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b090, 6); mov(eax, memd_a32[ds, eax + 0x351]);    /* mov eax, [eax+0x351] */
            ii(0x100d_b096, 5); calld(0x100c_fbbe, -0xb4dd);            /* call 0x100cfbbe */
            ii(0x100d_b09b, 2); jmpd(0x100d_b0f0, 0x53); goto l_0x100d_b0f0; /* jmp 0x100db0f0 */
        l_0x100d_b09d:
            ii(0x100d_b09d, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3e9);    /* cmp dword [ebp-0x4], 0x3e9 */
            ii(0x100d_b0a4, 2); if(jnzd(0x100d_b0b6, 0x10)) goto l_0x100d_b0b6; /* jnz 0x100db0b6 */
            ii(0x100d_b0a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b0a9, 6); mov(eax, memd_a32[ds, eax + 0x355]);    /* mov eax, [eax+0x355] */
            ii(0x100d_b0af, 5); calld(0x100c_fbbe, -0xb4f6);            /* call 0x100cfbbe */
            ii(0x100d_b0b4, 2); jmpd(0x100d_b0f0, 0x3a); goto l_0x100d_b0f0; /* jmp 0x100db0f0 */
        l_0x100d_b0b6:
            ii(0x100d_b0b6, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3ea);    /* cmp dword [ebp-0x4], 0x3ea */
            ii(0x100d_b0bd, 2); if(jnzd(0x100d_b0cf, 0x10)) goto l_0x100d_b0cf; /* jnz 0x100db0cf */
            ii(0x100d_b0bf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b0c2, 6); mov(eax, memd_a32[ds, eax + 0x359]);    /* mov eax, [eax+0x359] */
            ii(0x100d_b0c8, 5); calld(0x100c_fbbe, -0xb50f);            /* call 0x100cfbbe */
            ii(0x100d_b0cd, 2); jmpd(0x100d_b0f0, 0x21); goto l_0x100d_b0f0; /* jmp 0x100db0f0 */
        l_0x100d_b0cf:
            ii(0x100d_b0cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b0d2, 6); mov(eax, memd_a32[ds, eax + 0x345]);    /* mov eax, [eax+0x345] */
            ii(0x100d_b0d8, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100d_b0db, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100d_b0de, 3); mov(ebx, memd_a32[ds, eax + 0x40]);     /* mov ebx, [eax+0x40] */
            ii(0x100d_b0e1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_b0e4, 6); add(edx, 0x7000);                       /* add edx, 0x7000 */
            ii(0x100d_b0ea, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100d_b0ed, 3); calld_abs(memd_a32[ds, ebx + 0xc]);     /* call dword [ebx+0xc] */
        l_0x100d_b0f0:
            ii(0x100d_b0f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b0f3, 7); mov(memb_a32[ds, eax + 0x39e], 0x1);    /* mov byte [eax+0x39e], 0x1 */
            ii(0x100d_b0fa, 2); jmpd(0x100d_b11f, 0x23); goto l_0x100d_b11f; /* jmp 0x100db11f */
        l_0x100d_b0fc:
            ii(0x100d_b0fc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b0ff, 6); mov(eax, memd_a32[ds, eax + 0x345]);    /* mov eax, [eax+0x345] */
            ii(0x100d_b105, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100d_b108, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100d_b10b, 3); mov(ebx, memd_a32[ds, eax + 0x40]);     /* mov ebx, [eax+0x40] */
            ii(0x100d_b10e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_b111, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100d_b114, 3); calld_abs(memd_a32[ds, ebx + 0xc]);     /* call dword [ebx+0xc] */
            ii(0x100d_b117, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100d_b11a, 5); jmpd(0x100d_b21e, 0xff); goto l_0x100d_b21e; /* jmp 0x100db21e */
        l_0x100d_b11f:
            ii(0x100d_b11f, 5); jmpd(0x100d_b21a, 0xf6); goto l_0x100d_b21a; /* jmp 0x100db21a */
        l_0x100d_b124:
            ii(0x100d_b124, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3ee);   /* cmp dword [ebp-0x18], 0x3ee */
            ii(0x100d_b12b, 6); if(jbd(0x100d_b1b3, 0x82)) goto l_0x100d_b1b3; /* jb 0x100db1b3 */
            ii(0x100d_b131, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3ee);   /* cmp dword [ebp-0x18], 0x3ee */
            ii(0x100d_b138, 6); if(jbed(0x100d_ae96, -0x2a8)) goto l_0x100d_ae96; /* jbe 0x100dae96 */
            ii(0x100d_b13e, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3f2);   /* cmp dword [ebp-0x18], 0x3f2 */
            ii(0x100d_b145, 2); if(jbd(0x100d_b193, 0x4c)) goto l_0x100d_b193; /* jb 0x100db193 */
            ii(0x100d_b147, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3f2);   /* cmp dword [ebp-0x18], 0x3f2 */
            ii(0x100d_b14e, 6); if(jbed(0x100d_af72, -0x1e2)) goto l_0x100d_af72; /* jbe 0x100daf72 */
            ii(0x100d_b154, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3f4);   /* cmp dword [ebp-0x18], 0x3f4 */
            ii(0x100d_b15b, 2); if(jbd(0x100d_b18e, 0x31)) goto l_0x100d_b18e; /* jb 0x100db18e */
            ii(0x100d_b15d, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3f4);   /* cmp dword [ebp-0x18], 0x3f4 */
            ii(0x100d_b164, 6); if(jbed(0x100d_afca, -0x1a0)) goto l_0x100d_afca; /* jbe 0x100dafca */
            ii(0x100d_b16a, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3f5);   /* cmp dword [ebp-0x18], 0x3f5 */
            ii(0x100d_b171, 6); if(jbed(0x100d_aff6, -0x181)) goto l_0x100d_aff6; /* jbe 0x100daff6 */
            ii(0x100d_b177, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3f6);   /* cmp dword [ebp-0x18], 0x3f6 */
            ii(0x100d_b17e, 6); if(jzd(0x100d_b02b, -0x159)) goto l_0x100d_b02b; /* jz 0x100db02b */
            ii(0x100d_b184, 5); jmpd(0x100d_b060, -0x129); goto l_0x100d_b060; /* jmp 0x100db060 */
        //    ii(0x100d_b189, 5); jmpd(0x100d_b060, -0x12e); goto l_0x100d_b060; /* jmp 0x100db060 */
        l_0x100d_b18e:
            ii(0x100d_b18e, 5); jmpd(0x100d_af9e, -0x1f5); goto l_0x100d_af9e; /* jmp 0x100daf9e */
        l_0x100d_b193:
            ii(0x100d_b193, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3f0);   /* cmp dword [ebp-0x18], 0x3f0 */
            ii(0x100d_b19a, 2); if(jbd(0x100d_b1ae, 0x12)) goto l_0x100d_b1ae; /* jb 0x100db1ae */
            ii(0x100d_b19c, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3f0);   /* cmp dword [ebp-0x18], 0x3f0 */
            ii(0x100d_b1a3, 6); if(jbed(0x100d_af1a, -0x28f)) goto l_0x100d_af1a; /* jbe 0x100daf1a */
            ii(0x100d_b1a9, 5); jmpd(0x100d_af46, -0x268); goto l_0x100d_af46; /* jmp 0x100daf46 */
        l_0x100d_b1ae:
            ii(0x100d_b1ae, 5); jmpd(0x100d_aeee, -0x2c5); goto l_0x100d_aeee; /* jmp 0x100daeee */
        l_0x100d_b1b3:
            ii(0x100d_b1b3, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3ea);   /* cmp dword [ebp-0x18], 0x3ea */
            ii(0x100d_b1ba, 2); if(jbd(0x100d_b1e9, 0x2d)) goto l_0x100d_b1e9; /* jb 0x100db1e9 */
            ii(0x100d_b1bc, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3ea);   /* cmp dword [ebp-0x18], 0x3ea */
            ii(0x100d_b1c3, 6); if(jbed(0x100d_ae04, -0x3c5)) goto l_0x100d_ae04; /* jbe 0x100dae04 */
            ii(0x100d_b1c9, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3ec);   /* cmp dword [ebp-0x18], 0x3ec */
            ii(0x100d_b1d0, 2); if(jbd(0x100d_b1e4, 0x12)) goto l_0x100d_b1e4; /* jb 0x100db1e4 */
            ii(0x100d_b1d2, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3ec);   /* cmp dword [ebp-0x18], 0x3ec */
            ii(0x100d_b1d9, 6); if(jbed(0x100d_ae6a, -0x375)) goto l_0x100d_ae6a; /* jbe 0x100dae6a */
            ii(0x100d_b1df, 5); jmpd(0x100d_aec2, -0x322); goto l_0x100d_aec2; /* jmp 0x100daec2 */
        l_0x100d_b1e4:
            ii(0x100d_b1e4, 5); jmpd(0x100d_ae3e, -0x3ab); goto l_0x100d_ae3e; /* jmp 0x100dae3e */
        l_0x100d_b1e9:
            ii(0x100d_b1e9, 4); cmp(memd_a32[ss, ebp - 0x18], 0x1b);    /* cmp dword [ebp-0x18], 0x1b */
            ii(0x100d_b1ed, 2); if(jbd(0x100d_b20b, 0x1c)) goto l_0x100d_b20b; /* jb 0x100db20b */
            ii(0x100d_b1ef, 4); cmp(memd_a32[ss, ebp - 0x18], 0x1b);    /* cmp dword [ebp-0x18], 0x1b */
            ii(0x100d_b1f3, 6); if(jbed(0x100d_ae04, -0x3f5)) goto l_0x100d_ae04; /* jbe 0x100dae04 */
            ii(0x100d_b1f9, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3e8);   /* cmp dword [ebp-0x18], 0x3e8 */
            ii(0x100d_b200, 6); if(jzd(0x100d_ae1d, -0x3e9)) goto l_0x100d_ae1d; /* jz 0x100dae1d */
            ii(0x100d_b206, 5); jmpd(0x100d_b060, -0x1ab); goto l_0x100d_b060; /* jmp 0x100db060 */
        l_0x100d_b20b:
            ii(0x100d_b20b, 4); cmp(memd_a32[ss, ebp - 0x18], 0xd);     /* cmp dword [ebp-0x18], 0xd */
            ii(0x100d_b20f, 6); if(jzd(0x100d_ae1d, -0x3f8)) goto l_0x100d_ae1d; /* jz 0x100dae1d */
            ii(0x100d_b215, 5); jmpd(0x100d_b060, -0x1ba); goto l_0x100d_b060; /* jmp 0x100db060 */
        l_0x100d_b21a:
            ii(0x100d_b21a, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x100d_b21e:
            ii(0x100d_b21e, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100d_b221, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_b223, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_b224, 1); popd(edi);                              /* pop edi */
            ii(0x100d_b225, 1); popd(esi);                              /* pop esi */
            ii(0x100d_b226, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_b227, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_b228, 1); retd(); return;                         /* ret */
        }
    }
}

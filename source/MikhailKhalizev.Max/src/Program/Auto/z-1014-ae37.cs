using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_ae37-93f67ea1")]
        public void Method_1014_ae37()
        {
            ii(0x1014_ae37, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_ae3c, 5); calld(Definitions.sys_check_available_stack_size, 0x1_af11); /* call 0x10165d52 */
            ii(0x1014_ae41, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_ae42, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_ae43, 1); pushd(edx);                             /* push edx */
            ii(0x1014_ae44, 1); pushd(esi);                             /* push esi */
            ii(0x1014_ae45, 1); pushd(edi);                             /* push edi */
            ii(0x1014_ae46, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_ae47, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_ae49, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_ae4f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_ae52, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ae54, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ae57, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_ae5a, 5); calld(0x1008_b228, -0xb_fc37);          /* call 0x1008b228 */
            ii(0x1014_ae5f, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1014_ae62, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_ae65, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ae68, 4); mov(memb_a32[ds, eax + 0x3d], 0x4);     /* mov byte [eax+0x3d], 0x4 */
            ii(0x1014_ae6c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ae6e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ae71, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_ae74, 5); calld(0x1013_ad11, -0x1_0168);          /* call 0x1013ad11 */
            ii(0x1014_ae79, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ae7b, 2); if(jzd(0x1014_ae8a, 0xd)) goto l_0x1014_ae8a; /* jz 0x1014ae8a */
            ii(0x1014_ae7d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ae80, 5); calld(0x1014_adca, -0xbb);              /* call 0x1014adca */
            ii(0x1014_ae85, 5); jmpd(0x1014_af1b, 0x91); goto l_0x1014_af1b; /* jmp 0x1014af1b */
        l_0x1014_ae8a:
            ii(0x1014_ae8a, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x1014_ae8e, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1014_ae91, 3); add(ebx, 0x1c);                         /* add ebx, 0x1c */
            ii(0x1014_ae94, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_ae97, 3); add(edx, 0x1a);                         /* add edx, 0x1a */
            ii(0x1014_ae9a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ae9d, 5); calld(0x100c_e1a2, -0x7_cd00);          /* call 0x100ce1a2 */
            ii(0x1014_aea2, 1); cwde();                                 /* cwde */
            ii(0x1014_aea3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_aea5, 2); if(jnzd(0x1014_aedb, 0x34)) goto l_0x1014_aedb; /* jnz 0x1014aedb */
            ii(0x1014_aea7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_aea9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_aeac, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_aeb1, 5); calld(0x1007_6630, -0xd_4886);          /* call 0x10076630 */
            ii(0x1014_aeb6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_aeb9, 5); calld(0x1014_adca, -0xf4);              /* call 0x1014adca */
            ii(0x1014_aebe, 5); calld(0x1010_2bf8, -0x4_82cb);          /* call 0x10102bf8 */
            ii(0x1014_aec3, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_aec5, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1014_aec7, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_aecc, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_aecf, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1014_aed4, 5); calld(0x1013_d5c0, -0xd919);            /* call 0x1013d5c0 */
            ii(0x1014_aed9, 2); jmpd(0x1014_af1b, 0x40); goto l_0x1014_af1b; /* jmp 0x1014af1b */
        l_0x1014_aedb:
            ii(0x1014_aedb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_aede, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1014_aee2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_aee5, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1014_aee9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_aeec, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1014_aef0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_aef3, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1014_aef7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_aefa, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_aefd, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_aeff, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_af02, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1014_af06, 5); calld(0x100d_4b64, -0x7_63a7);          /* call 0x100d4b64 */
            ii(0x1014_af0b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_af0d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_af10, 3); mov(memb_a32[ds, eax + 0x45], dl);      /* mov [eax+0x45], dl */
            ii(0x1014_af13, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_af16, 5); calld(0x1015_1565, 0x664a);             /* call 0x10151565 */
        l_0x1014_af1b:
            ii(0x1014_af1b, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1014_af20, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_af23, 5); calld(0x1007_6d98, -0xd_4190);          /* call 0x10076d98 */
            ii(0x1014_af28, 2); test(al, al);                           /* test al, al */
            ii(0x1014_af2a, 2); if(jzd(0x1014_af39, 0xd)) goto l_0x1014_af39; /* jz 0x1014af39 */
            ii(0x1014_af2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_af2f, 5); calld(0x1010_094d, -0x4_a5e7);          /* call 0x1010094d */
            ii(0x1014_af34, 5); calld(0x100f_f5c1, -0x4_b978);          /* call 0x100ff5c1 */
        l_0x1014_af39:
            ii(0x1014_af39, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_af3b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_af3c, 1); popd(edi);                              /* pop edi */
            ii(0x1014_af3d, 1); popd(esi);                              /* pop esi */
            ii(0x1014_af3e, 1); popd(edx);                              /* pop edx */
            ii(0x1014_af3f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_af40, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_af41, 1); retd(); return;                         /* ret */
        }
    }
}

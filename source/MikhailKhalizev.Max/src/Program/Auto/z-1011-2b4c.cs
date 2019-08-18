using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_2b4c-7ed63be2")]
        public void Method_1011_2b4c()
        {
            ii(0x1011_2b4c, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1011_2b51, 5); calld(Definitions.sys_check_available_stack_size, 0x5_31fc); /* call 0x10165d52 */
            ii(0x1011_2b56, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_2b57, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_2b58, 1); pushd(edx);                             /* push edx */
            ii(0x1011_2b59, 1); pushd(esi);                             /* push esi */
            ii(0x1011_2b5a, 1); pushd(edi);                             /* push edi */
            ii(0x1011_2b5b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_2b5c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_2b5e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_2b64, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_2b67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2b6a, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_2b6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2b6f, 6); mov(eax, memd_a32[ds, eax + 0x5a1]);    /* mov eax, [eax+0x5a1] */
            ii(0x1011_2b75, 5); calld(0x100d_7f6c, -0x3_ac0e);          /* call 0x100d7f6c */
            ii(0x1011_2b7a, 5); calld(0x1011_5318, 0x2799);             /* call 0x10115318 */
            ii(0x1011_2b7f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_2b84, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2b85, 5); calld(0x1011_5338, 0x27ae);             /* call 0x10115338 */
            ii(0x1011_2b8a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_2b8c, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1011_2b8e, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x1011_2b93, 5); mov(edx, 0x101b_9d8c);                  /* mov edx, 0x101b9d8c */
            ii(0x1011_2b98, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2b9b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_2b9d, 5); calld(0x1010_8a05, -0xa19d);            /* call 0x10108a05 */
            ii(0x1011_2ba2, 5); calld(0x1011_5318, 0x2771);             /* call 0x10115318 */
            ii(0x1011_2ba7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_2bac, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2bad, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1011_2bb2, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x1011_2bb7, 5); mov(edx, 0x101b_9da0);                  /* mov edx, 0x101b9da0 */
            ii(0x1011_2bbc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2bbf, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_2bc1, 5); calld(0x1010_8a05, -0xa1c1);            /* call 0x10108a05 */
            ii(0x1011_2bc6, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_2bcb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_2bcd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2bd0, 5); calld(0x1011_285d, -0x378);             /* call 0x1011285d */
            ii(0x1011_2bd5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2bd8, 4); cmp(memd_a32[ds, eax + 0x1a], 0);       /* cmp dword [eax+0x1a], 0x0 */
            ii(0x1011_2bdc, 2); if(jzd(0x1011_2c12, 0x34)) goto l_0x1011_2c12; /* jz 0x10112c12 */
            ii(0x1011_2bde, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2be1, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1011_2be4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_2be7, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1011_2beb, 2); if(jzd(0x1011_2c01, 0x14)) goto l_0x1011_2c01; /* jz 0x10112c01 */
            ii(0x1011_2bed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_2bef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2bf2, 5); calld(Definitions.my_dtor_d2, -0x4_46bf); /* call 0x100ce538 */
            ii(0x1011_2bf7, 5); calld(Definitions.sys_delete, 0x5_3368); /* call 0x10165f64 */
            ii(0x1011_2bfc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_2bff, 2); jmpd(0x1011_2c08, 0x7); goto l_0x1011_2c08; /* jmp 0x10112c08 */
        l_0x1011_2c01:
            ii(0x1011_2c01, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1011_2c08:
            ii(0x1011_2c08, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2c0b, 7); mov(memd_a32[ds, eax + 0x1a], 0);       /* mov dword [eax+0x1a], 0x0 */
        l_0x1011_2c12:
            ii(0x1011_2c12, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_2c17, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_2c1c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2c1f, 5); calld(0x1011_285d, -0x3c7);             /* call 0x1011285d */
            ii(0x1011_2c24, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2c27, 7); cmp(memb_a32[ds, eax + 0x51f], 0);      /* cmp byte [eax+0x51f], 0x0 */
            ii(0x1011_2c2e, 2); if(jzd(0x1011_2c3d, 0xd)) goto l_0x1011_2c3d; /* jz 0x10112c3d */
            ii(0x1011_2c30, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_2c32, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2c35, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1011_2c38, 5); calld(0x100c_fb06, -0x4_3137);          /* call 0x100cfb06 */
        l_0x1011_2c3d:
            ii(0x1011_2c3d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_2c3f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_2c40, 1); popd(edi);                              /* pop edi */
            ii(0x1011_2c41, 1); popd(esi);                              /* pop esi */
            ii(0x1011_2c42, 1); popd(edx);                              /* pop edx */
            ii(0x1011_2c43, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_2c44, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_2c45, 1); retd(); return;                         /* ret */
        }
    }
}

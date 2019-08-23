using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_0da4-193b4733")]
        public void Method_1010_0da4()
        {
            ii(0x1010_0da4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_0da9, 5); calld(Definitions.sys_check_available_stack_size, 0x6_4fa4); /* call 0x10165d52 */
            ii(0x1010_0dae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_0daf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_0db0, 1); pushd(edx);                             /* push edx */
            ii(0x1010_0db1, 1); pushd(esi);                             /* push esi */
            ii(0x1010_0db2, 1); pushd(edi);                             /* push edi */
            ii(0x1010_0db3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_0db4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_0db6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_0dbc, 7); cmp(memb_a32[ds, 0x101c_3970], 0);      /* cmp byte [0x101c3970], 0x0 */
            ii(0x1010_0dc3, 2); if(jzd(0x1010_0e1f, 0x5a)) goto l_0x1010_0e1f; /* jz 0x10100e1f */
            ii(0x1010_0dc5, 5); calld(0x1014_82f4, 0x4_752a);           /* call 0x101482f4 */
            ii(0x1010_0dca, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_0dcd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_0dd0, 6); sub(eax, memd_a32[ds, 0x101c_396c]);    /* sub eax, [0x101c396c] */
            ii(0x1010_0dd6, 5); mov(ebx, 0x12_34dc);                    /* mov ebx, 0x1234dc */
            ii(0x1010_0ddb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0ddd, 2); div(ebx);                               /* div ebx */
            ii(0x1010_0ddf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_0de2, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1010_0de6, 2); if(jzd(0x1010_0e1f, 0x37)) goto l_0x1010_0e1f; /* jz 0x10100e1f */
            ii(0x1010_0de8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_0deb, 5); mov(memd_a32[ds, 0x101c_396c], eax);    /* mov [0x101c396c], eax */
            ii(0x1010_0df0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_0df3, 7); sub(memw_a32[ds, 0x101c_3962], ax);     /* sub [0x101c3962], ax */
            ii(0x1010_0dfa, 5); mov(eax, memd_a32[ds, 0x101c_3960]);    /* mov eax, [0x101c3960] */
            ii(0x1010_0dff, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0e02, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0e04, 2); if(jgd(0x1010_0e16, 0x10)) goto l_0x1010_0e16; /* jg 0x10100e16 */
            ii(0x1010_0e06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0e08, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0e0a, 5); calld(0x100f_b4fd, -0x5912);            /* call 0x100fb4fd */
            ii(0x1010_0e0f, 7); mov(memb_a32[ds, 0x101c_37d2], 0x1);    /* mov byte [0x101c37d2], 0x1 */
        l_0x1010_0e16:
            ii(0x1010_0e16, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
            ii(0x1010_0e1d, 2); jmpd(0x1010_0e26, 0x7); goto l_0x1010_0e26; /* jmp 0x10100e26 */
        l_0x1010_0e1f:
            ii(0x1010_0e1f, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1010_0e26:
            ii(0x1010_0e26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0e29, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_0e2b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_0e2c, 1); popd(edi);                              /* pop edi */
            ii(0x1010_0e2d, 1); popd(esi);                              /* pop esi */
            ii(0x1010_0e2e, 1); popd(edx);                              /* pop edx */
            ii(0x1010_0e2f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_0e30, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_0e31, 1); retd();                                 /* ret */
        }
    }
}

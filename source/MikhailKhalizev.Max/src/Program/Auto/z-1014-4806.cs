using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_4806-513e88b3")]
        public void Method_1014_4806()
        {
            ii(0x1014_4806, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_480b, 5); calld(Definitions.sys_check_available_stack_size, 0x2_1542); /* call 0x10165d52 */
            ii(0x1014_4810, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_4811, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_4812, 1); pushd(edx);                             /* push edx */
            ii(0x1014_4813, 1); pushd(esi);                             /* push esi */
            ii(0x1014_4814, 1); pushd(edi);                             /* push edi */
            ii(0x1014_4815, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_4816, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_4818, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_481e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_4821, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4824, 6); mov(ebx, memd_a32[ds, eax + 0x150]);    /* mov ebx, [eax+0x150] */
            ii(0x1014_482a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_482d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4830, 6); mov(edx, memd_a32[ds, eax + 0x168]);    /* mov edx, [eax+0x168] */
            ii(0x1014_4836, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_4839, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_483c, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1014_483f, 5); calld(0x1014_44e6, -0x35e);             /* call 0x101444e6 */
            ii(0x1014_4844, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1014_4846, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_4849, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_484c, 6); mov(eax, memd_a32[ds, eax + 0x15a]);    /* mov eax, [eax+0x15a] */
            ii(0x1014_4852, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_4855, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1014_4858, 2); if(jged(0x1014_4869, 0xf)) goto l_0x1014_4869; /* jge 0x10144869 */
            ii(0x1014_485a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_485d, 6); mov(eax, memd_a32[ds, eax + 0x15a]);    /* mov eax, [eax+0x15a] */
            ii(0x1014_4863, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_4866, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1014_4869:
            ii(0x1014_4869, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_486d, 2); if(jzd(0x1014_48c3, 0x54)) goto l_0x1014_48c3; /* jz 0x101448c3 */
            ii(0x1014_486f, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_4873, 2); if(jled(0x1014_489e, 0x29)) goto l_0x1014_489e; /* jle 0x1014489e */
            ii(0x1014_4875, 5); mov(ecx, 0x40);                         /* mov ecx, 0x40 */
            ii(0x1014_487a, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_487d, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x1014_4882, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4885, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_4888, 5); calld(0x1007_68e0, -0xc_dfad);          /* call 0x100768e0 */
            ii(0x1014_488d, 5); calld(0x1014_37d1, -0x10c1);            /* call 0x101437d1 */
            ii(0x1014_4892, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_4894, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4897, 5); calld(0x1014_47a0, -0xfc);              /* call 0x101447a0 */
            ii(0x1014_489c, 2); jmpd(0x1014_48c3, 0x25); goto l_0x1014_48c3; /* jmp 0x101448c3 */
        l_0x1014_489e:
            ii(0x1014_489e, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_48a1, 2); neg(ebx);                               /* neg ebx */
            ii(0x1014_48a3, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x1014_48a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_48ab, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_48ae, 5); calld(0x1007_68e0, -0xc_dfd3);          /* call 0x100768e0 */
            ii(0x1014_48b3, 5); calld(0x1014_3b69, -0xd4f);             /* call 0x10143b69 */
            ii(0x1014_48b8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_48bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_48be, 5); calld(0x1014_47a0, -0x123);             /* call 0x101447a0 */
        l_0x1014_48c3:
            ii(0x1014_48c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_48c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_48c6, 1); popd(edi);                              /* pop edi */
            ii(0x1014_48c7, 1); popd(esi);                              /* pop esi */
            ii(0x1014_48c8, 1); popd(edx);                              /* pop edx */
            ii(0x1014_48c9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_48ca, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_48cb, 1); retd();                                 /* ret */
        }
    }
}

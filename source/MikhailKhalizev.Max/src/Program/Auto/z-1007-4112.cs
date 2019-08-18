using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4112-87c473e3")]
        public void Method_1007_4112()
        {
            ii(0x1007_4112, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_4117, 5); calld(Definitions.sys_check_available_stack_size, 0xf_1c36); /* call 0x10165d52 */
            ii(0x1007_411c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_411d, 1); pushd(esi);                             /* push esi */
            ii(0x1007_411e, 1); pushd(edi);                             /* push edi */
            ii(0x1007_411f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_4120, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_4122, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_4128, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_412b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_412e, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1007_4131, 7); test(memd_a32[ss, ebp - 0xc], 0x10);    /* test dword [ebp-0xc], 0x10 */
            ii(0x1007_4138, 2); if(jzd(0x1007_41a5, 0x6b)) goto l_0x1007_41a5; /* jz 0x100741a5 */
            ii(0x1007_413a, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_413e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_4141, 1); inc(eax);                               /* inc eax */
            ii(0x1007_4142, 1); cwde();                                 /* cwde */
            ii(0x1007_4143, 5); calld(0x1007_3cfd, -0x44b);             /* call 0x10073cfd */
            ii(0x1007_4148, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_414d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_4150, 2); if(jzd(0x1007_415e, 0xc)) goto l_0x1007_415e; /* jz 0x1007415e */
            ii(0x1007_4152, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_4159, 5); jmpd(0x1007_41d2, 0x74); goto l_0x1007_41d2; /* jmp 0x100741d2 */
        l_0x1007_415e:
            ii(0x1007_415e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_4161, 1); inc(eax);                               /* inc eax */
            ii(0x1007_4162, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_4165, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_4169, 5); calld(0x1007_3cfd, -0x471);             /* call 0x10073cfd */
            ii(0x1007_416e, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_4173, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_4176, 2); if(jzd(0x1007_4181, 0x9)) goto l_0x1007_4181; /* jz 0x10074181 */
            ii(0x1007_4178, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_417f, 2); jmpd(0x1007_41d2, 0x51); goto l_0x1007_41d2; /* jmp 0x100741d2 */
        l_0x1007_4181:
            ii(0x1007_4181, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_4184, 1); inc(eax);                               /* inc eax */
            ii(0x1007_4185, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_4188, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_418b, 1); inc(eax);                               /* inc eax */
            ii(0x1007_418c, 1); cwde();                                 /* cwde */
            ii(0x1007_418d, 5); calld(0x1007_3cfd, -0x495);             /* call 0x10073cfd */
            ii(0x1007_4192, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_4197, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_419a, 2); if(jzd(0x1007_41a5, 0x9)) goto l_0x1007_41a5; /* jz 0x100741a5 */
            ii(0x1007_419c, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_41a3, 2); jmpd(0x1007_41d2, 0x2d); goto l_0x1007_41d2; /* jmp 0x100741d2 */
        l_0x1007_41a5:
            ii(0x1007_41a5, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_41a9, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_41ad, 5); calld(0x1007_3cfd, -0x4b5);             /* call 0x10073cfd */
            ii(0x1007_41b2, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_41b7, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_41ba, 2); if(jnzd(0x1007_41c5, 0x9)) goto l_0x1007_41c5; /* jnz 0x100741c5 */
            ii(0x1007_41bc, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x1007_41c3, 2); jmpd(0x1007_41cc, 0x7); goto l_0x1007_41cc; /* jmp 0x100741cc */
        l_0x1007_41c5:
            ii(0x1007_41c5, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1007_41cc:
            ii(0x1007_41cc, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_41cf, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1007_41d2:
            ii(0x1007_41d2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_41d5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_41d7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_41d8, 1); popd(edi);                              /* pop edi */
            ii(0x1007_41d9, 1); popd(esi);                              /* pop esi */
            ii(0x1007_41da, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_41db, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_48d6-58cdb1a6")]
        public void Method_1011_48d6()
        {
            ii(0x1011_48d6, 5); pushd(0xd8);                            /* push 0xd8 */
            ii(0x1011_48db, 5); calld(Definitions.sys_check_available_stack_size, 0x5_1472); /* call 0x10165d52 */
            ii(0x1011_48e0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_48e1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_48e2, 1); pushd(edx);                             /* push edx */
            ii(0x1011_48e3, 1); pushd(esi);                             /* push esi */
            ii(0x1011_48e4, 1); pushd(edi);                             /* push edi */
            ii(0x1011_48e5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_48e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_48e8, 6); sub(esp, 0xbc);                         /* sub esp, 0xbc */
            ii(0x1011_48ee, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_48f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_48f4, 5); calld(0x1011_3b89, -0xd70);             /* call 0x10113b89 */
            ii(0x1011_48f9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_48fb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_48fd, 5); calld(0x1013_843f, 0x2_3b3d);           /* call 0x1013843f */
            ii(0x1011_4902, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_4905, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1011_4909, 6); if(jzd(0x1011_49c1, 0xb2)) goto l_0x1011_49c1; /* jz 0x101149c1 */
            ii(0x1011_490f, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1011_4912, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_4915, 6); mov(memb_a32[ds, edx + 0x598], al);     /* mov [edx+0x598], al */
            ii(0x1011_491b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_491e, 5); mov(eax, 0x3d);                         /* mov eax, 0x3d */
            ii(0x1011_4923, 5); calld(0x100c_aafc, -0x4_9e2c);          /* call 0x100caafc */
            ii(0x1011_4928, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1011_492d, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_4932, 5); calld(0x100c_aafc, -0x4_9e3b);          /* call 0x100caafc */
            ii(0x1011_4937, 5); calld(0x1011_5398, 0xa5c);              /* call 0x10115398 */
            ii(0x1011_493c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_493e, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1011_4940, 6); lea(ebx, ebp - 0xbc);                   /* lea ebx, [ebp-0xbc] */
            ii(0x1011_4946, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1011_494b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_494f, 5); calld(0x1013_9ade, 0x2_518a);           /* call 0x10139ade */
            ii(0x1011_4954, 7); mov(memd_a32[ss, ebp - 0xc], 0x4);      /* mov dword [ebp-0xc], 0x4 */
        l_0x1011_495b:
            ii(0x1011_495b, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1011_495e, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1011_4963, 2); if(jzd(0x1011_4981, 0x1c)) goto l_0x1011_4981; /* jz 0x10114981 */
            ii(0x1011_4965, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_4969, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_496b, 4); mov(dl, memb_a32[ds, eax + ebp - 0x1b]); /* mov dl, [eax+ebp-0x1b] */
            ii(0x1011_496f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_4973, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_4975, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_4978, 7); mov(memw_a32[ds, eax + 0x4e4], dx);     /* mov [eax+0x4e4], dx */
            ii(0x1011_497f, 2); jmpd(0x1011_495b, -0x26); goto l_0x1011_495b; /* jmp 0x1011495b */
        l_0x1011_4981:
            ii(0x1011_4981, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1011_4986, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4989, 5); calld(0x1011_2a06, -0x1f88);            /* call 0x10112a06 */
            ii(0x1011_498e, 6); lea(edx, ebp - 0xbc);                   /* lea edx, [ebp-0xbc] */
            ii(0x1011_4994, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4997, 5); calld(0x1011_46da, -0x2c2);             /* call 0x101146da */
            ii(0x1011_499c, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_49a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_49a4, 5); calld(0x1011_3aca, -0xedf);             /* call 0x10113aca */
            ii(0x1011_49a9, 6); lea(edx, ebp - 0xbc);                   /* lea edx, [ebp-0xbc] */
            ii(0x1011_49af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_49b2, 5); calld(0x1011_3f91, -0xa26);             /* call 0x10113f91 */
            ii(0x1011_49b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_49ba, 5); calld(0x1011_390d, -0x10b2);            /* call 0x1011390d */
            ii(0x1011_49bf, 2); jmpd(0x1011_49ce, 0xd); goto l_0x1011_49ce; /* jmp 0x101149ce */
        l_0x1011_49c1:
            ii(0x1011_49c1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_49c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_49c9, 5); calld(0x1011_3aca, -0xf04);             /* call 0x10113aca */
        l_0x1011_49ce:
            ii(0x1011_49ce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_49d0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_49d1, 1); popd(edi);                              /* pop edi */
            ii(0x1011_49d2, 1); popd(esi);                              /* pop esi */
            ii(0x1011_49d3, 1); popd(edx);                              /* pop edx */
            ii(0x1011_49d4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_49d5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_49d6, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5056-1f5794f5")]
        public void Method_1014_5056()
        {
            ii(0x1014_5056, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1014_505b, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0cf2); /* call 0x10165d52 */
            ii(0x1014_5060, 1); pushd(esi);                             /* push esi */
            ii(0x1014_5061, 1); pushd(edi);                             /* push edi */
            ii(0x1014_5062, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5063, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5065, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_506b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_506e, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_5071, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1014_5074, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1014_5077, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1014_507b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_507e, 5); calld(Definitions.my_string_ctor, -0x359b); /* call 0x10141ae8 */
            ii(0x1014_5083, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_5086, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1014_508a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_508d, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_5090, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1014_5094, 1); pushd(eax);                             /* push eax */
            ii(0x1014_5095, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_5098, 1); pushd(eax);                             /* push eax */
            ii(0x1014_5099, 5); mov(eax, StringDefinitions.ErrorInLineLiColumnI); /* mov eax, 0x101acf88 */
            ii(0x1014_509e, 1); pushd(eax);                             /* push eax */
            ii(0x1014_509f, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1014_50a4, 1); pushd(eax);                             /* push eax */
            ii(0x1014_50a5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_50a8, 1); pushd(eax);                             /* push eax */
            ii(0x1014_50a9, 5); calld(0x1014_2037, -0x3077);            /* call 0x10142037 */
            ii(0x1014_50ae, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1014_50b1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_50b4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_50b7, 5); calld(Definitions.my_string_append_char_ptr, -0x337d); /* call 0x10141d3f */
            ii(0x1014_50bc, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_50bf, 5); calld(0x100e_aef0, -0x5_a1d4);          /* call 0x100eaef0 */
            ii(0x1014_50c4, 1); dec(eax);                               /* dec eax */
            ii(0x1014_50c5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_50c8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_50cb, 5); calld(Definitions.my_string_get, -0x2e3e); /* call 0x10142292 */
            ii(0x1014_50d0, 3); cmp(memb_a32[ds, eax], 0xa);            /* cmp byte [eax], 0xa */
            ii(0x1014_50d3, 2); if(jzd(0x1014_50e2, 0xd)) goto l_0x1014_50e2; /* jz 0x101450e2 */
            ii(0x1014_50d5, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1014_50da, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_50dd, 5); calld(Definitions.my_string_append_char, -0x32f8); /* call 0x10141dea */
        l_0x1014_50e2:
            ii(0x1014_50e2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1014_50e5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_50e8, 5); calld(Definitions.my_string_append_char_ptr, -0x33ae); /* call 0x10141d3f */
            ii(0x1014_50ed, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1014_50f2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_50f5, 5); calld(Definitions.my_string_append_char, -0x3310); /* call 0x10141dea */
        l_0x1014_50fa:
            ii(0x1014_50fa, 4); add(memd_a32[ss, ebp + 0x10], -0x1 /* 0xff */); /* add dword [ebp+0x10], 0xffffffff */
            ii(0x1014_50fe, 5); cmp(memw_a32[ss, ebp + 0x10], 0);       /* cmp word [ebp+0x10], 0x0 */
            ii(0x1014_5103, 2); if(jzd(0x1014_511a, 0x15)) goto l_0x1014_511a; /* jz 0x1014511a */
            ii(0x1014_5105, 5); mov(edx, 0x2a);                         /* mov edx, 0x2a */
            ii(0x1014_510a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_510d, 5); calld(Definitions.my_string_append_char, -0x3328); /* call 0x10141dea */
            ii(0x1014_5112, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_5115, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
            ii(0x1014_5118, 2); jmpd(0x1014_50fa, -0x20); goto l_0x1014_50fa; /* jmp 0x101450fa */
        l_0x1014_511a:
            ii(0x1014_511a, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1014_511d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_5120, 5); calld(Definitions.my_string_append_char_ptr, -0x33e6); /* call 0x10141d3f */
            ii(0x1014_5125, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1014_5128, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_512b, 5); calld(Definitions.my_string_ctor_string, -0x368a); /* call 0x10141aa6 */
            ii(0x1014_5130, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5132, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_5135, 5); calld(Definitions.my_string_dtor, -0x3610); /* call 0x10141b2a */
            ii(0x1014_513a, 2); jmpd(0x1014_5146, 0xa); goto l_0x1014_5146; /* jmp 0x10145146 */
        //  ii(0x1014_513c, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_513e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //  ii(0x1014_5141, 5); calld(Definitions.my_string_dtor, -0x361c); /* call 0x10141b2a */
        l_0x1014_5146:
            ii(0x1014_5146, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_5149, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_514b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_514c, 1); popd(edi);                              /* pop edi */
            ii(0x1014_514d, 1); popd(esi);                              /* pop esi */
            ii(0x1014_514e, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}

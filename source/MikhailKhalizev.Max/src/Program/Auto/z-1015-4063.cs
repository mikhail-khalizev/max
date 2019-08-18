using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("985fe738-065c-4dc5-962b-4be8156be9e9")]
        public void Method_1015_4063()
        {
            ii(0x1015_4063, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1015_4068, 5); calld(Definitions.sys_check_available_stack_size, 0x1_1ce5); /* call 0x10165d52 */
            ii(0x1015_406d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_406e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_406f, 1); pushd(edx);                             /* push edx */
            ii(0x1015_4070, 1); pushd(esi);                             /* push esi */
            ii(0x1015_4071, 1); pushd(edi);                             /* push edi */
            ii(0x1015_4072, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_4073, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_4075, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_407b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_407e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4081, 3); inc(memb_a32[ds, eax + 0x6b]);          /* inc byte [eax+0x6b] */
            ii(0x1015_4084, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4087, 4); and(memb_a32[ds, eax + 0x6b], 0xf);     /* and byte [eax+0x6b], 0xf */
            ii(0x1015_408b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_408e, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1015_4092, 2); if(jnzd(0x1015_4105, 0x71)) goto l_0x1015_4105; /* jnz 0x10154105 */
            ii(0x1015_4094, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4097, 3); mov(al, memb_a32[ds, eax + 0x6b]);      /* mov al, [eax+0x6b] */
            ii(0x1015_409a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_409f, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1015_40a1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_40a4, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_40a8, 8); movsx(ax, memb_a32[ds, eax + 0x101b_d914]); /* movsx ax, byte [eax+0x101bd914] */
            ii(0x1015_40b0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_40b3, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_40b7, 8); movsx(ax, memb_a32[ds, eax + 0x101b_d91c]); /* movsx ax, byte [eax+0x101bd91c] */
            ii(0x1015_40bf, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_40c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_40c5, 5); calld(0x1014_9fa8, -0xa122);            /* call 0x10149fa8 */
            ii(0x1015_40ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_40cd, 4); test(memb_a32[ds, eax + 0x6b], 0x1);    /* test byte [eax+0x6b], 0x1 */
            ii(0x1015_40d1, 2); if(jzd(0x1015_40e5, 0x12)) goto l_0x1015_40e5; /* jz 0x101540e5 */
            ii(0x1015_40d3, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1015_40d7, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1015_40db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_40de, 5); calld(0x1014_9c2f, -0xa4b4);            /* call 0x10149c2f */
            ii(0x1015_40e3, 2); jmpd(0x1015_40fd, 0x18); goto l_0x1015_40fd; /* jmp 0x101540fd */
        l_0x1015_40e5:
            ii(0x1015_40e5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_40e8, 2); neg(eax);                               /* neg eax */
            ii(0x1015_40ea, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_40ed, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_40f0, 2); neg(eax);                               /* neg eax */
            ii(0x1015_40f2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_40f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_40f8, 5); calld(0x1014_9c2f, -0xa4ce);            /* call 0x10149c2f */
        l_0x1015_40fd:
            ii(0x1015_40fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4100, 5); calld(0x1014_9fa8, -0xa15d);            /* call 0x10149fa8 */
        l_0x1015_4105:
            ii(0x1015_4105, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_4107, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_4108, 1); popd(edi);                              /* pop edi */
            ii(0x1015_4109, 1); popd(esi);                              /* pop esi */
            ii(0x1015_410a, 1); popd(edx);                              /* pop edx */
            ii(0x1015_410b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_410c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_410d, 1); retd(); return;                         /* ret */
        }
    }
}

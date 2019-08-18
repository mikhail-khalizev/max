using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_a11c-547fe0f5")]
        public void Method_100e_a11c()
        {
            ii(0x100e_a11c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_a121, 5); calld(Definitions.sys_check_available_stack_size, 0x7_bc2c); /* call 0x10165d52 */
            ii(0x100e_a126, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_a127, 1); pushd(esi);                             /* push esi */
            ii(0x100e_a128, 1); pushd(edi);                             /* push edi */
            ii(0x100e_a129, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_a12a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a12c, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_a132, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_a135, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_a138, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100e_a13b, 3); lea(edi, ebp - 0x14);                   /* lea edi, [ebp-0x14] */
            ii(0x100e_a13e, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100e_a141, 2); movsw_a32();                            /* movsw */
            ii(0x100e_a143, 1); movsb_a32();                            /* movsb */
        l_0x100e_a144:
            ii(0x100e_a144, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100e_a147, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_a14a, 5); calld(0x100e_a067, -0xe8);              /* call 0x100ea067 */
            ii(0x100e_a14f, 2); test(al, al);                           /* test al, al */
            ii(0x100e_a151, 2); if(jzd(0x100e_a179, 0x26)) goto l_0x100e_a179; /* jz 0x100ea179 */
            ii(0x100e_a153, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_a156, 3); add(memb_a32[ss, ebp - 0x12], al);      /* add [ebp-0x12], al */
            ii(0x100e_a159, 4); movsx(eax, memb_a32[ss, ebp - 0x12]);   /* movsx eax, byte [ebp-0x12] */
            ii(0x100e_a15d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_a15f, 2); if(jld(0x100e_a16a, 0x9)) goto l_0x100e_a16a; /* jl 0x100ea16a */
            ii(0x100e_a161, 4); movsx(eax, memb_a32[ss, ebp - 0x12]);   /* movsx eax, byte [ebp-0x12] */
            ii(0x100e_a165, 3); cmp(eax, 0x1f);                         /* cmp eax, 0x1f */
            ii(0x100e_a168, 2); if(jled(0x100e_a177, 0xd)) goto l_0x100e_a177; /* jle 0x100ea177 */
        l_0x100e_a16a:
            ii(0x100e_a16a, 5); movsx(ax, memb_a32[ss, ebp - 0x12]);    /* movsx ax, byte [ebp-0x12] */
            ii(0x100e_a16f, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x100e_a172, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_a175, 2); jmpd(0x100e_a184, 0xd); goto l_0x100e_a184; /* jmp 0x100ea184 */
        l_0x100e_a177:
            ii(0x100e_a177, 2); jmpd(0x100e_a144, -0x35); goto l_0x100e_a144; /* jmp 0x100ea144 */
        l_0x100e_a179:
            ii(0x100e_a179, 5); movsx(ax, memb_a32[ss, ebp - 0x12]);    /* movsx ax, byte [ebp-0x12] */
            ii(0x100e_a17e, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x100e_a181, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100e_a184:
            ii(0x100e_a184, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_a187, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a189, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_a18a, 1); popd(edi);                              /* pop edi */
            ii(0x100e_a18b, 1); popd(esi);                              /* pop esi */
            ii(0x100e_a18c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_a18d, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("79a51edb-f193-499b-b873-cf07eb14c148")]
        public void Method_1011_f0b6()
        {
            ii(0x1011_f0b6, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1011_f0bb, 5); calld(Definitions.sys_check_available_stack_size, 0x4_6c92); /* call 0x10165d52 */
            ii(0x1011_f0c0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_f0c1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_f0c2, 1); pushd(esi);                             /* push esi */
            ii(0x1011_f0c3, 1); pushd(edi);                             /* push edi */
            ii(0x1011_f0c4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_f0c5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_f0c7, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_f0cd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_f0d0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_f0d3, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_f0d7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f0d9, 2); if(jld(0x1011_f0e3, 0x8)) goto l_0x1011_f0e3; /* jl 0x1011f0e3 */
            ii(0x1011_f0db, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_f0df, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f0e1, 2); if(jged(0x1011_f0e5, 0x2)) goto l_0x1011_f0e5; /* jge 0x1011f0e5 */
        l_0x1011_f0e3:
            ii(0x1011_f0e3, 2); jmpd(0x1011_f0f1, 0xc); goto l_0x1011_f0f1; /* jmp 0x1011f0f1 */
        l_0x1011_f0e5:
            ii(0x1011_f0e5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_f0e8, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1011_f0ef, 2); if(jld(0x1011_f0f3, 0x2)) goto l_0x1011_f0f3; /* jl 0x1011f0f3 */
        l_0x1011_f0f1:
            ii(0x1011_f0f1, 2); jmpd(0x1011_f0ff, 0xc); goto l_0x1011_f0ff; /* jmp 0x1011f0ff */
        l_0x1011_f0f3:
            ii(0x1011_f0f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_f0f6, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1011_f0fd, 2); if(jld(0x1011_f105, 0x6)) goto l_0x1011_f105; /* jl 0x1011f105 */
        l_0x1011_f0ff:
            ii(0x1011_f0ff, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1011_f103, 2); jmpd(0x1011_f145, 0x40); goto l_0x1011_f145; /* jmp 0x1011f145 */
        l_0x1011_f105:
            ii(0x1011_f105, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_f109, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_f10c, 6); mov(edx, memd_a32[ds, 0x101c_5368]);    /* mov edx, [0x101c5368] */
            ii(0x1011_f112, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f114, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1011_f118, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_f11a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_f11c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_f11e, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1011_f120, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_f123, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_f127, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f129, 2); if(jzd(0x1011_f133, 0x8)) goto l_0x1011_f133; /* jz 0x1011f133 */
            ii(0x1011_f12b, 6); test(memw_a32[ss, ebp - 0x10], 0x80);   /* test word [ebp-0x10], 0x80 */
            ii(0x1011_f131, 2); if(jzd(0x1011_f135, 0x2)) goto l_0x1011_f135; /* jz 0x1011f135 */
        l_0x1011_f133:
            ii(0x1011_f133, 2); jmpd(0x1011_f13b, 0x6); goto l_0x1011_f13b; /* jmp 0x1011f13b */
        l_0x1011_f135:
            ii(0x1011_f135, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1011_f139, 2); jmpd(0x1011_f13f, 0x4); goto l_0x1011_f13f; /* jmp 0x1011f13f */
        l_0x1011_f13b:
            ii(0x1011_f13b, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x1011_f13f:
            ii(0x1011_f13f, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1011_f142, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x1011_f145:
            ii(0x1011_f145, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_f148, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_f14a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_f14b, 1); popd(edi);                              /* pop edi */
            ii(0x1011_f14c, 1); popd(esi);                              /* pop esi */
            ii(0x1011_f14d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_f14e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_f14f, 1); retd(); return;                         /* ret */
        }
    }
}

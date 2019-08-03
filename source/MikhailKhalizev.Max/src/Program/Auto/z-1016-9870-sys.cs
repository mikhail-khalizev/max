using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0483147b-560f-4266-8256-063a605a0827")]
        public void /* sys */ Method_1016_9870()
        {
            ii(0x1016_9870, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_9871, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_9872, 1); pushd(edx);                             /* push edx */
            ii(0x1016_9873, 1); pushd(esi);                             /* push esi */
            ii(0x1016_9874, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_9877, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_987e, 2); if(jnzd(0x1016_9887, 0x7)) goto l_0x1016_9887; /* jnz 0x10169887 */
            ii(0x1016_9880, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_9885, 2); jmpd(0x1016_98ea, 0x63); goto l_0x1016_98ea; /* jmp 0x101698ea */
        l_0x1016_9887:
            ii(0x1016_9887, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_9889, 5); calld(/* sys */ 0x1016_7f00, -0x198e);  /* call 0x10167f00 */
            ii(0x1016_988e, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_9890, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_9892, 2); if(jnzd(0x1016_98a1, 0xd)) goto l_0x1016_98a1; /* jnz 0x101698a1 */
            ii(0x1016_9894, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_9899, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_989c, 1); popd(esi);                              /* pop esi */
            ii(0x1016_989d, 1); popd(edx);                              /* pop edx */
            ii(0x1016_989e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_989f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_98a0, 1); retd(); return;                         /* ret */
        l_0x1016_98a1:
            ii(0x1016_98a1, 4); test(memb_a32[ds, eax + 0x4], 0x8);     /* test byte [eax+0x4], 0x8 */
            ii(0x1016_98a5, 2); if(jnzd(0x1016_98e8, 0x41)) goto l_0x1016_98e8; /* jnz 0x101698e8 */
            ii(0x1016_98a7, 3); mov(dl, memb_a32[ds, esi + 0x4]);       /* mov dl, [esi+0x4] */
            ii(0x1016_98aa, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_98ac, 3); or(dl, 0x8);                            /* or dl, 0x8 */
            ii(0x1016_98af, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_98b4, 3); mov(memb_a32[ds, esi + 0x4], dl);       /* mov [esi+0x4], dl */
            ii(0x1016_98b7, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_98b9, 3); mov(ebx, memd_a32[ds, esi + 0x48]);     /* mov ebx, [esi+0x48] */
            ii(0x1016_98bc, 4); mov(edx, memd_a32[ss, esp + 0x4]);      /* mov edx, [esp+0x4] */
            ii(0x1016_98c0, 5); calld(/* sys */ 0x1016_9b90, 0x2cb);    /* call 0x10169b90 */
            ii(0x1016_98c5, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1016_98c8, 3); mov(ebx, memd_a32[ds, eax + 0x34]);     /* mov ebx, [eax+0x34] */
            ii(0x1016_98cb, 2); cmp(esi, ebx);                          /* cmp esi, ebx */
            ii(0x1016_98cd, 2); if(jnzd(0x1016_98e8, 0x19)) goto l_0x1016_98e8; /* jnz 0x101698e8 */
            ii(0x1016_98cf, 3); mov(ecx, memd_a32[ds, ebx + 0x1c]);     /* mov ecx, [ebx+0x1c] */
            ii(0x1016_98d2, 3); cmp(ecx, -0x1 /* 0xff */);              /* cmp ecx, 0xffffffff */
            ii(0x1016_98d5, 2); if(jzd(0x1016_98de, 0x7)) goto l_0x1016_98de; /* jz 0x101698de */
            ii(0x1016_98d7, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_98d9, 5); calld(/* sys */ 0x1016_b280, 0x19a2);   /* call 0x1016b280 */
        l_0x1016_98de:
            ii(0x1016_98de, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1016_98e1, 7); mov(memd_a32[ds, eax + 0x34], 0);       /* mov dword [eax+0x34], 0x0 */
        l_0x1016_98e8:
            ii(0x1016_98e8, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_98ea:
            ii(0x1016_98ea, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_98ed, 1); popd(esi);                              /* pop esi */
            ii(0x1016_98ee, 1); popd(edx);                              /* pop edx */
            ii(0x1016_98ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_98f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_98f1, 1); retd(); return;                         /* ret */
        }
    }
}
